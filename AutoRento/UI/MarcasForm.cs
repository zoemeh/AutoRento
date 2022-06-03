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
    public partial class MarcasForm : Form
    {
        readonly Marca marca = new Marca();
        readonly MarcaRepo marcaRepo = new MarcaRepo();
        public MarcasForm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            marcasGrid.DataSource = marcaRepo.View();
            marcasGrid.ClearSelection();
        }

        private Marca GetMarca()
        {
            marca.Descripcion = descripcionText.Text.Trim();
            marca.Estado = estadoCheck.Checked;
            return marca;
        }

        private void Clear()
        {
            descripcionText.Text = "";
            estadoCheck.Checked = false;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            marcaRepo.Create(GetMarca());
            LoadData();
            Clear();
        }

        private void MarcasForm_Load(object sender, EventArgs e)
        {
            marcasGrid.DataSource = marcaRepo.View();
            marcasGrid.ClearSelection();
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            marcaRepo.Update(GetMarca());
            LoadData();
            Clear();
        }

        private void otroBtn_Click(object sender, EventArgs e)
        {

        }

        private void borrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var t = GetMarca();
                if (t != null)
                {
                    marcaRepo.Delete(t);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void marcasGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            marca.Id = Convert.ToInt32(marcasGrid.SelectedRows[0].Cells[0].Value.ToString());
            marca.Descripcion = marcasGrid.SelectedRows[0].Cells[1].Value.ToString();
            marca.Estado = Convert.ToBoolean(marcasGrid.SelectedRows[0].Cells[2].Value.ToString());
            descripcionText.Text = marca.Descripcion;
            estadoCheck.Checked = marca.Estado;
        }
    }
}
