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
    public partial class VehiculosDetailForm : Form
    {
        public Vehiculo vehiculo = new Vehiculo();
        internal VehiculoRepo vehiculoRepo = new VehiculoRepo();
        internal MarcaRepo marcaRepo = new MarcaRepo();
        internal ModeloRepo modeloRepo = new ModeloRepo();
        internal TipoCombustibleRepo tipoCombustibleRepo = new TipoCombustibleRepo();
        internal TipoVehiculoRepo tipoVehiculoRepo = new TipoVehiculoRepo();
        internal List<string> errores = new List<string>();
        public bool Editando { get; set; }

        public VehiculosDetailForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            marcaCombo.DataSource = marcaRepo.View();
            tipoConbustibleCombo.DataSource = tipoCombustibleRepo.View();
            tipoVehiculoCombo.DataSource = tipoVehiculoRepo.View();
            modeloCombo.Enabled = false;
        }

        public Vehiculo FillVehiculo()
        {
            vehiculo.Descripcion = descripcionText.Text.Trim();
            vehiculo.NumeroChasis = chasisText.Text.Trim();
            vehiculo.NumeroMotor = motorText.Text.Trim();
            vehiculo.NumeroPlaca = placaText.Text.Trim();
            using AutoRentoContext db = new AutoRentoContext();
            var tipoVehiculo = db.TiposVehiculo.Where(x => x.Descripcion == tipoVehiculoCombo.Text).FirstOrDefault();
            vehiculo.TipoVehiculoId = (int)tipoVehiculo.Id;
            var marca = db.Marcas.Where(x => x.Descripcion == marcaCombo.Text).FirstOrDefault();
            vehiculo.MarcaId = (int)marca.Id;
            var modelo = db.Modelos.Where(x => x.Descripcion == modeloCombo.Text && x.MarcaId == marca.Id).FirstOrDefault();
            vehiculo.ModeloId = (int)modelo.Id;
            var tipoCombustible = db.TiposCombustible.Where(x => x.Descripcion == tipoConbustibleCombo.Text).FirstOrDefault();
            vehiculo.TipoCombustibleId = (int)tipoCombustible.Id;
            vehiculo.Estado = estadoCheck.Checked;
            return vehiculo;
        }

        public void FillForm()
        {
            descripcionText.Text = vehiculo.Descripcion;
            chasisText.Text = vehiculo.NumeroChasis;
            motorText.Text = vehiculo.NumeroMotor;
            placaText.Text = vehiculo.NumeroPlaca;
            tipoVehiculoCombo.Text = vehiculo.TipoVehiculo.Descripcion;
            marcaCombo.Text = vehiculo.Marca.Descripcion;
            modeloCombo.DataSource = modeloRepo.View(vehiculo.Marca);
            modeloCombo.Enabled = true;
            modeloCombo.Text = vehiculo.Modelo.Descripcion;
            tipoConbustibleCombo.Text = vehiculo.TipoCombustible.Descripcion;
        }
        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                FillVehiculo();
                if (Editando)
                {
                    vehiculoRepo.Update(FillVehiculo());
                }
                else
                {
                    vehiculoRepo.Create(FillVehiculo());
                }
                Close();
            }

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void marcaCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // llenar modelos de esta marca
            using AutoRentoContext db = new AutoRentoContext();
            var marca = db.Marcas.Where(x => x.Descripcion == marcaCombo.Text).FirstOrDefault();
            if (marca != null)
            {
                var modelos = modeloRepo.View(marca);
                modeloCombo.DataSource = modelos;

                if (modelos.Count == 0)
                {
                    modeloCombo.Enabled = false;
                    MessageBox.Show("Esta marca no tiene modelos");
                }
                else
                {
                    modeloCombo.Enabled = true;

                }
            }
        }
        public bool Validar()
        {
            errores.Clear();
            if (string.IsNullOrWhiteSpace(descripcionText.Text.Trim()))
            {
                errores.Add("Descripcion no puede estar en blanco");
            }
            if (string.IsNullOrWhiteSpace(motorText.Text.Trim()))
            {
                errores.Add("No. de motor no puede estar en blanco");
            }
            if (string.IsNullOrWhiteSpace(chasisText.Text.Trim()))
            {
                errores.Add("No. de chasis no puede estar en blanco");
            }
            if (string.IsNullOrWhiteSpace(placaText.Text.Trim()))
            {
                errores.Add("No. de placa no puede estar en blanco");
            }
            if (string.IsNullOrWhiteSpace(tipoVehiculoCombo.Text.Trim()))
            {
                errores.Add("Tipo de vehiculo no puede estar en blanco");
            }
            if (string.IsNullOrWhiteSpace(marcaCombo.Text.Trim()))
            {
                errores.Add("Marca no puede estar en blanco");
            }
            if (string.IsNullOrWhiteSpace(modeloCombo.Text.Trim()))
            {
                errores.Add("Modelo no puede estar en blanco");
            }
            if (string.IsNullOrWhiteSpace(tipoConbustibleCombo.Text.Trim()))
            {
                errores.Add("Tipo de combustible no puede estar en blanco");
            }

            using AutoRentoContext db = new AutoRentoContext();
            if (db.Vehiculos.Where(x => x.Descripcion == descripcionText.Text.Trim()).Any())
            {
                errores.Add("Ya existe un vehiculo con esa descripcion.");
            }
            if (db.Vehiculos.Where(x => x.NumeroChasis == chasisText.Text.Trim()).Any())
            {
                errores.Add("Ya existe un vehiculo con ese numero de chasis.");
            }
            if(db.Vehiculos.Where(x => x.NumeroPlaca == placaText.Text.Trim()).Any())
            {
                errores.Add("Ya existe un vehiculo con ese numero de placa.");
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
