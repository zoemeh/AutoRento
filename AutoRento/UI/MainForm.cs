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
    public partial class MainForm : Form
    {
        public ClientesForm clientesForm;
        public EmpleadosForm empleadosForm;
        public MarcasForm marcasForm;
        public ModelosForm modelosForm;
        public RentaForm rentaForm;
        public ReportesForm reportesForm;
        public TiposCombustibleForm tiposCombustibleForm;
        public TiposVehiculoForm tiposVehiculoForm;
        public VehiculosForm vehiculosForm;
        public InspeccionForm inspeccionForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var l = new LoginForm();
            l.ShowDialog();
        }

        private void combustibleBtn_Click(object sender, EventArgs e)
        {
            if (tiposCombustibleForm == null || tiposCombustibleForm.IsDisposed)
            {
                tiposCombustibleForm = new TiposCombustibleForm();
                tiposCombustibleForm.Show();
                tiposCombustibleForm.LoadData();
            }
            else
            {
                tiposCombustibleForm.Show();
                tiposCombustibleForm.LoadData();
                tiposCombustibleForm.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (marcasForm == null || marcasForm.IsDisposed)
            {
                marcasForm = new MarcasForm();
                marcasForm.Show();
                marcasForm.LoadData();
            }
            else
            {
                marcasForm.Show();
                marcasForm.LoadData();
                marcasForm.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (modelosForm == null || modelosForm.IsDisposed)
            {
                modelosForm = new ModelosForm();
                modelosForm.Show();
                modelosForm.LoadData();
            }
            else
            {
                modelosForm.Show();
                modelosForm.LoadData();
                modelosForm.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tiposVehiculoForm == null || tiposVehiculoForm.IsDisposed)
            {
                tiposVehiculoForm = new TiposVehiculoForm();
                tiposVehiculoForm.Show();
                tiposVehiculoForm.LoadData();

            }
            else
            {
                tiposVehiculoForm.Show();
                tiposVehiculoForm.LoadData();
                tiposVehiculoForm.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vehiculosForm == null || vehiculosForm.IsDisposed)
            {
                vehiculosForm = new VehiculosForm();
                vehiculosForm.Show();
                vehiculosForm.LoadData();
            }
            else
            {
                vehiculosForm.Show();
                vehiculosForm.LoadData();
                vehiculosForm.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clientesForm == null || clientesForm.IsDisposed)
            {
                clientesForm = new ClientesForm();
                clientesForm.Show();
                clientesForm.LoadData();
            }
            else
            {
                clientesForm.Show();
                clientesForm.LoadData();
                clientesForm.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (empleadosForm == null || empleadosForm.IsDisposed)
            {
                empleadosForm = new EmpleadosForm();
                empleadosForm.Show();
                empleadosForm.LoadData();
            }
            else
            {
                empleadosForm.Show();
                empleadosForm.LoadData();
                empleadosForm.Focus();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (rentaForm == null || rentaForm.IsDisposed)
            {
                rentaForm = new RentaForm();
                rentaForm.Show();
                rentaForm.LoadData();
            }
            else
            {
                rentaForm.Show();
                rentaForm.LoadData();
                rentaForm.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inspeccionForm == null || inspeccionForm.IsDisposed)
            {
                inspeccionForm = new InspeccionForm();
                inspeccionForm.Show();
                inspeccionForm.LoadData();
            }
            else
            {
                inspeccionForm.Show();
                inspeccionForm.LoadData();
                inspeccionForm.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (reportesForm == null || reportesForm.IsDisposed)
            {
                reportesForm = new ReportesForm();
                reportesForm.Show();
                reportesForm.LoadData();
            }
            else
            {
                reportesForm.Show();
                reportesForm.LoadData();
                reportesForm.Focus();
            }
        }
    }
}
