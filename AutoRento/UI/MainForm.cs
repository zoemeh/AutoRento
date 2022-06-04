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
            }
            else
            {
                tiposCombustibleForm.Show();
                tiposCombustibleForm.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (marcasForm == null || marcasForm.IsDisposed)
            {
                marcasForm = new MarcasForm();
                marcasForm.Show();
            }
            else
            {
                marcasForm.Show();
                marcasForm.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (modelosForm == null || modelosForm.IsDisposed)
            {
                modelosForm = new ModelosForm();
                modelosForm.LoadData();
                modelosForm.Show();
            }
            else
            {
                modelosForm.LoadData();
                modelosForm.Show();
                modelosForm.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tiposVehiculoForm == null || tiposVehiculoForm.IsDisposed)
            {
                tiposVehiculoForm = new TiposVehiculoForm();
                tiposVehiculoForm.LoadData();
                tiposVehiculoForm.Show();
            }
            else
            {
                tiposVehiculoForm.LoadData();
                tiposVehiculoForm.Show();
                tiposVehiculoForm.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vehiculosForm == null || vehiculosForm.IsDisposed)
            {
                vehiculosForm = new VehiculosForm();
                vehiculosForm.LoadData();
                vehiculosForm.Show();
            }
            else
            {
                vehiculosForm.LoadData();
                vehiculosForm.Show();
                vehiculosForm.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clientesForm == null || clientesForm.IsDisposed)
            {
                clientesForm = new ClientesForm();
                clientesForm.LoadData();
                clientesForm.Show();
            }
            else
            {
                clientesForm.LoadData();
                clientesForm.Show();
                clientesForm.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (empleadosForm == null || empleadosForm.IsDisposed)
            {
                empleadosForm = new EmpleadosForm();
                empleadosForm.LoadData();
                empleadosForm.Show();
            }
            else
            {
                empleadosForm.LoadData();
                empleadosForm.Show();
                empleadosForm.Focus();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (rentaForm == null || rentaForm.IsDisposed)
            {
                rentaForm = new RentaForm();
                rentaForm.LoadData();
                rentaForm.Show();
            }
            else
            {
                rentaForm.LoadData();
                rentaForm.Show();
                rentaForm.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (inspeccionForm == null || inspeccionForm.IsDisposed)
            {
                inspeccionForm = new InspeccionForm();
                inspeccionForm.LoadData();
                inspeccionForm.Show();
            }
            else
            {
                inspeccionForm.LoadData();
                inspeccionForm.Show();
                inspeccionForm.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (reportesForm == null || reportesForm.IsDisposed)
            {
                reportesForm = new ReportesForm();
                reportesForm.Show();
            }
            else
            {
                reportesForm.Show();
                reportesForm.Focus();
            }
        }
    }
}
