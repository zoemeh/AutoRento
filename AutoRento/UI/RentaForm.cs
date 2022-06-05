using AutoRento.Data;
using AutoRento.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRento.UI
{
    public partial class RentaForm : Form
    {
        Renta renta = new Renta();
        VehiculoRepo vehiculoRepo = new VehiculoRepo();
        ClienteRepo clienteRepo = new ClienteRepo();
        EmpleadoRepo empleadoRepo = new EmpleadoRepo();
        RentaRepo rentaRepo = new RentaRepo();
        public List<string> errores = new List<string>();
        public RentaForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            clienteCombo.DataSource = clienteRepo.View();
            vehiculoCombo.DataSource = vehiculoRepo.View();
            empleadoCombo.DataSource = empleadoRepo.View();
            dataGridView1.DataSource = rentaRepo.View();
            dataGridView1.ClearSelection();
        }
        public Renta GetRenta()
        {
            using AutoRentoContext db = new AutoRentoContext();
            renta.EmpleadoId = ((Empleado)empleadoCombo.SelectedItem).Id;
            renta.ClienteId = ((Cliente)clienteCombo.SelectedItem).Id;
            renta.VehiculoId = ((Vehiculo)vehiculoCombo.SelectedItem).Id;
            renta.FechaRenta = rentaDate.Value;
            renta.FechaDevolucion = devolucionDate.Value;
            renta.MontoDia = Convert.ToDouble(montoText.Value);
            renta.Comentario = comentarioText.Text.Trim();

            return renta;
        }

        private void Clear()
        {
            montoText.Value = 0;
            comentarioText.Text = "";
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                rentaRepo.Create(GetRenta());
                LoadData();
                Clear();
            }
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                rentaRepo.Update(GetRenta());
                LoadData();
                Clear();
            }
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var t = GetRenta();
                if (t != null)
                {
                    rentaRepo.Delete(t);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            editarBtn.Enabled = dataGridView1.SelectedRows.Count > 0;
            borrarBtn.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renta.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            renta.EmpleadoId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            renta.ClienteId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            renta.VehiculoId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            renta.FechaRenta = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
            renta.FechaDevolucion = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
            renta.MontoDia = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
            renta.Comentario = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            renta.Estado = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[11].Value.ToString());
            renta.Devuelto = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[12].Value.ToString());
            using AutoRentoContext db = new AutoRentoContext();
            empleadoCombo.SelectedItem = db.Empleados.Where(x => x.Id == renta.EmpleadoId).FirstOrDefault();
            clienteCombo.SelectedItem = db.Clientes.Where(x => x.Id == renta.ClienteId).FirstOrDefault();
            vehiculoCombo.SelectedItem = db.Vehiculos.Where(x => x.Id == renta.VehiculoId).FirstOrDefault();
            rentaDate.Value = renta.FechaRenta;
            devolucionDate.Value = renta.FechaDevolucion;
            montoText.Value = Convert.ToDecimal(renta.MontoDia);
            comentarioText.Text = renta.Comentario;
        }
        public bool Validar()
        {
            errores.Clear();
            if (rentaDate.Value > devolucionDate.Value)
            {
                errores.Add("La fecha de renta debe ser menor a la fecha de devolucion.");
            }
            if (montoText.Value < 0)
            {
                errores.Add("Monto por dia debe ser mayor a 0");
            }
            if (renta.Devuelto == true)
            {
                errores.Add("No se pueden modificar vehiculos ya devueltos.");
            }
            using AutoRentoContext db = new AutoRentoContext();
            if (db.Rentas.Where(x => x.VehiculoId == GetRenta().VehiculoId && x.Devuelto == false && x.Id != renta.Id).Any())
            {
                errores.Add("Este vehiculo ya esta rentado.");
            }
            if (db.Inspecciones.Where(x => x.Fecha.Date < renta.FechaRenta && x.VehiculoId == renta.VehiculoId).Any())
            {
                errores.Add("Vehiculo debe ser inspeccionado hoy antes de rentar.");
            }
            if (errores.Count > 0)
            {
                var message = "";
                foreach (var e in errores)
                {
                    message += e + "\n";
                }
                MessageBox.Show(message);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void otroBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Devolver este auto?", "Confirmar Devolver", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var r = GetRenta();
                r.Devuelto = true;
                rentaRepo.Update(r);
                LoadData();
            }
        }
    }
}
