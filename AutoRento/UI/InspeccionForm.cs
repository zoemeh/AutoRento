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
    public partial class InspeccionForm : Form
    {
        VehiculoRepo vehiculoRepo = new VehiculoRepo();
        ClienteRepo clienteRepo = new ClienteRepo();
        EmpleadoRepo empleadoRepo = new EmpleadoRepo();
        InspeccionRepo inspeccionRepo = new InspeccionRepo();
        readonly Inspeccion inspeccion = new Inspeccion();
        public InspeccionForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            vehiculoCombo.DataSource = vehiculoRepo.View();
            clienteCombo.DataSource = clienteRepo.View();
            empleadoCombo.DataSource = empleadoRepo.View();
            dataGridView1.DataSource = inspeccionRepo.View();
            dataGridView1.ClearSelection();
        }

        public Inspeccion GetInspeccion()
        {
            inspeccion.tieneRalladuras = ralladurasCheck.Checked;
            inspeccion.Combustible = Convert.ToDouble(combustibleCombo.Text);
            inspeccion.TieneGomaRespuesta = repuestaCheck.Checked;
            inspeccion.TieneGato = gatoCheck.Checked;
            inspeccion.TieneRoturaCristal = cristalCheck.Checked;
            inspeccion.CheckGomaIzqD = GomaIzqFcheck.Checked;
            inspeccion.CheckGomaIzqT = gomaIzqTCheck.Checked;
            inspeccion.CheckGomaDerD = GomaDerFCheck.Checked;
            inspeccion.CheckGomaDerT = GomaDerTCheck.Checked;
            inspeccion.Fecha = fechaCheck.Value;
            var vehiculo = (Vehiculo)vehiculoCombo.SelectedItem;
            inspeccion.VehiculoId = vehiculo.Id;
            var cliente = (Cliente)clienteCombo.SelectedItem;
            inspeccion.ClienteId = cliente.Id;
            var empleado = (Empleado)empleadoCombo.SelectedItem;
            inspeccion.EmpleadoId = (int)empleado.Id;
            
            return inspeccion;
        }
        private void Clear()
        {
            
            ralladurasCheck.Checked = false;
            gatoCheck.Checked = false;
            cristalCheck.Checked = false;
            GomaIzqFcheck.Checked = false;
            gomaIzqTCheck.Checked = false;
            GomaDerFCheck.Checked = false;
            GomaDerTCheck.Checked = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            inspeccion.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            using AutoRentoContext db = new AutoRentoContext();
            inspeccion.VehiculoId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            var vehiculo = db.Vehiculos.Where(x => x.Id == inspeccion.VehiculoId).FirstOrDefault();
            if (vehiculo != null)
            {
                inspeccion.Vehiculo = vehiculo;
            } else
            {
                // TODO: ERROR
            }
            inspeccion.ClienteId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            inspeccion.Combustible = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            inspeccion.tieneRalladuras = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            inspeccion.TieneGomaRespuesta = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
            inspeccion.TieneGato = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
            inspeccion.TieneRoturaCristal = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
            inspeccion.CheckGomaIzqD = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[10].Value.ToString());
            inspeccion.CheckGomaIzqT = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[11].Value.ToString());
            inspeccion.CheckGomaDerD = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[12].Value.ToString());
            inspeccion.CheckGomaDerT = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[13].Value.ToString());
            inspeccion.Fecha = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[14].Value.ToString());
            inspeccion.EmpleadoId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[15].Value.ToString());
            var empleado = db.Empleados.Where(x => x.Id == inspeccion.EmpleadoId).FirstOrDefault();
            inspeccion.Empleado = empleado;
            //inspeccion.Estado = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[16].Value.ToString());
            combustibleCombo.Text = inspeccion.Combustible.ToString();
            ralladurasCheck.Checked = inspeccion.tieneRalladuras;
            gatoCheck.Checked = inspeccion.TieneGato;
            cristalCheck.Checked = inspeccion.TieneRoturaCristal;
            GomaIzqFcheck.Checked = inspeccion.CheckGomaIzqD;
            gomaIzqTCheck.Checked = inspeccion.CheckGomaIzqT;
            GomaDerFCheck.Checked = inspeccion.CheckGomaDerD;
            GomaDerTCheck.Checked = inspeccion.CheckGomaDerT;

        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            inspeccionRepo.Create(GetInspeccion());
            LoadData();
            Clear();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            inspeccionRepo.Update(GetInspeccion());
            LoadData();
            Clear();
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var t = GetInspeccion();
                if (t != null)
                {
                    inspeccionRepo.Delete(t);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
    }
}
