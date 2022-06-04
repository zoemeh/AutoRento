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
    public partial class ClientesForm : Form
    {
        readonly ClienteRepo clienteRepo = new ClienteRepo();
        private int clienteId;
        public ClientesForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = clienteRepo.View();
            dataGridView1.ClearSelection();
        }

        private Cliente GetCliente()
        {
            using AutoRentoContext db = new AutoRentoContext();
            return db.Clientes.Where(x => x.Id == clienteId).FirstOrDefault();
        }
        private void crearBtn_Click(object sender, EventArgs e)
        {
            var f = new ClientesDetailForm();
            f.LoadData();
            f.Editando = false;
            f.Text = "Crear Cliente";
            f.ShowDialog();
            LoadData();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            var c = GetCliente();
            if (c == null)
            {
                return;
            }
            var f = new ClientesDetailForm();
            f.LoadData();
            f.Editando = true;
            f.cliente = c;
            f.FillForm();
            f.Text = "Editar Cliente";
            f.ShowDialog();
            LoadData();
        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var t = GetCliente();
                if (t != null)
                {
                    clienteRepo.Delete(t);
                    LoadData();
                }
            }

            catch(Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                MessageBox.Show("No es posible borrar este cliente porque es referenciado por otras tablas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void otroBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clienteId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            borrarBtn.Enabled = dataGridView1.SelectedRows.Count > 0;
            editarBtn.Enabled = dataGridView1.SelectedRows.Count > 0;
        }
    }
}
