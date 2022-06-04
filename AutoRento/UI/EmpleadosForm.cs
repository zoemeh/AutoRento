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
    public partial class EmpleadosForm : Form
    {
        readonly EmpleadoRepo empleadoRepo = new EmpleadoRepo();
        private int empleadoId;

        public EmpleadosForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = empleadoRepo.View();
            dataGridView1.ClearSelection();
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            var f = new EmpleadosDetailForm();
            f.LoadData();
            f.Editando = false;
            f.Text = "Crear Empleado";
            f.ShowDialog();
            LoadData();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            var f = new EmpleadosDetailForm();
            f.LoadData();
            f.Editando = true;
            f.empleado = GetEmpleado();
            f.FillForm();
            f.Text = "Editar Empleado";
            f.ShowDialog();
            LoadData();
        }
        private Empleado GetEmpleado()
        {
            using AutoRentoContext db = new AutoRentoContext();
            return db.Empleados.Where(x => x.Id == empleadoId).FirstOrDefault();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            empleadoId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var t = GetEmpleado();
                if (t != null)
                {
                    empleadoRepo.Delete(t);
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
            borrarBtn.Enabled = dataGridView1.SelectedRows.Count > 0;
            editarBtn.Enabled = dataGridView1.SelectedRows.Count > 0;

        }
    }
}
