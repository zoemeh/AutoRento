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
    public partial class TiposVehiculoForm : Form
    {
        readonly TipoVehiculo tiposVehiculo = new TipoVehiculo();
        readonly TipoVehiculoRepo tiposVehiculoRepo = new TipoVehiculoRepo();
        List<string> errores = new List<string>();
        public TiposVehiculoForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = tiposVehiculoRepo.View();
            dataGridView1.ClearSelection();
        }
        private TipoVehiculo GetTipoVehiculo()
        {
            tiposVehiculo.Descripcion = descripcionText.Text.Trim();
            tiposVehiculo.Estado = estadoCheck.Checked;
            return tiposVehiculo;
        }

        private void Clear()
        {
            descripcionText.Text = "";
            estadoCheck.Checked = false;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            tiposVehiculo.Id = null;
            if (Validar())
            {
                tiposVehiculoRepo.Create(GetTipoVehiculo());
                LoadData();
                Clear();
            }

        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            if (tiposVehiculo == null)
            {
                return;
            }
            if (Validar())
            {
                tiposVehiculoRepo.Update(GetTipoVehiculo());
                LoadData();
                Clear();
            }
        }

        private void otroBtn_Click(object sender, EventArgs e)
        {

        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {

            try
            {
                var t = GetTipoVehiculo();
                if (t != null)
                {
                    tiposVehiculoRepo.Delete(t);
                    LoadData();
                    Clear();
                }
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                MessageBox.Show("No es posible borrar este vehiculo porque es referenciado por otras tablas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tiposVehiculo.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            tiposVehiculo.Descripcion = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tiposVehiculo.Estado = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            descripcionText.Text = tiposVehiculo.Descripcion;
            estadoCheck.Checked = tiposVehiculo.Estado;
        }

        public bool Validar()
        {
            errores.Clear();
            if (string.IsNullOrWhiteSpace(descripcionText.Text))
            {
                errores.Add("Descripción no puede estar en blanco");
            }
            using AutoRentoContext db = new AutoRentoContext();
            if (db.TiposVehiculo.Where(x => x.Descripcion == descripcionText.Text.Trim() && x.Id != tiposVehiculo.Id).Any())
            {
                errores.Add("Ya existe un tipo de vehiculo con esa descripción");
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            borrarBtn.Enabled = dataGridView1.SelectedRows.Count > 0;
            actualizarBtn.Enabled = dataGridView1.SelectedRows.Count > 0;
        }
    }
}
