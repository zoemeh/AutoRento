using AutoRento.Data;
using AutoRento.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class VehiculosForm : Form
    {
        readonly VehiculoRepo vehiculoRepo = new VehiculoRepo();
        private int vehiculoId;

        public VehiculosForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = vehiculoRepo.View();
            dataGridView1.ClearSelection();
        }
        private void crearBtn_Click(object sender, EventArgs e)
        {
            var f = new VehiculosDetailForm();
            f.LoadData();
            f.Editando = false;
            f.Text = "Crear Vehiculo";
            f.ShowDialog();
            LoadData();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            var f = new VehiculosDetailForm();
            f.LoadData();
            f.Editando = true;
            f.vehiculo = GetVehiclo();
            f.FillForm();
            f.Text = "Editar Vehiculo";
            f.ShowDialog();
            LoadData();
        }

        private Vehiculo GetVehiclo()
        {
            using AutoRentoContext db = new AutoRentoContext();
            return db.Vehiculos.Include(x => x.Modelo).Include(x => x.Marca).Include(x => x.TipoVehiculo).Include(x => x.TipoCombustible).Where(x => x.Id == vehiculoId).FirstOrDefault();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vehiculoId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var t = GetVehiclo();
                if (t != null)
                {
                    vehiculoRepo.Delete(t);
                    LoadData();
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            button4.Enabled = dataGridView1.SelectedRows.Count > 0;
            editarBtn.Enabled = dataGridView1.SelectedRows.Count > 0;

        }
    }
}
