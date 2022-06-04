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
    public partial class ModelosForm : Form
    {
        readonly Modelo modelo = new Modelo();
        readonly ModeloRepo modeloRepo = new ModeloRepo();
        readonly MarcaRepo marcaRepo = new MarcaRepo();
        List<string> errores = new List<string>();
        public ModelosForm()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            dataGridView1.DataSource = modeloRepo.View();
            marcasCombo.DataSource = marcaRepo.View();
            dataGridView1.ClearSelection();
        }

        private Modelo GetModelo()
        {
            modelo.Descripcion = descripcionText.Text.Trim();
            modelo.Estado = estadoCheck.Checked;
            using AutoRentoContext db = new AutoRentoContext();
            var marca = db.Marcas.Where(x => x.Descripcion == marcasCombo.Text).FirstOrDefault();
            if (marca != null)
            {
                modelo.MarcaId = marca.Id;
                modelo.Marca = marca;
            }
            else
            {
                modelo.MarcaId = null;
                modelo.Marca = null;
            }

            return modelo;
        }

        private void Clear()
        {
            descripcionText.Text = "";
            estadoCheck.Checked = false;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            modelo.Id = null;
            if (Validar())
            {
                modeloRepo.Create(GetModelo());
                LoadData();
                Clear();
            }
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                modeloRepo.Update(GetModelo());
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
                var t = GetModelo();
                if (t != null)
                {
                    modeloRepo.Delete(t);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modelo.Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            modelo.Descripcion = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            modelo.Estado = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            using AutoRentoContext db = new AutoRentoContext();
            var marca = db.Marcas.Where(x => x.Id == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString())).FirstOrDefault();
            if (marca != null)
            {
                modelo.MarcaId = marca.Id;
                modelo.Marca = marca;
            }
            else
            {
                modelo.MarcaId = null;
                modelo.Marca = null;
            }
            descripcionText.Text = modelo.Descripcion;
            estadoCheck.Checked = modelo.Estado;
        }
        public bool Validar()
        {
            errores.Clear();
            if (string.IsNullOrWhiteSpace(descripcionText.Text))
            {
                errores.Add("Descripción no puede estar en blanco");
            }
            if (string.IsNullOrWhiteSpace(marcasCombo.Text))
            {
                errores.Add("Debe ser parte de una Marca.");
            }
            using AutoRentoContext db = new AutoRentoContext();
            var marca = (Marca)marcasCombo.SelectedItem;
            if (db.Modelos.Where(x => x.Descripcion == descripcionText.Text.Trim() && x.MarcaId == marca.Id && x.Id != modelo.Id).Any())
            {
                errores.Add("Ya existe un modelo con este nombre para esta marca.");
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
    }
}
