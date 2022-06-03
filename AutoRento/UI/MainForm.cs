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
        public TiposCombustibleForm tiposCombustibleForm;
        public MarcasForm marcasForm;
        public ModelosForm modelosForm;
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
            if ( tiposCombustibleForm == null || tiposCombustibleForm.IsDisposed)
            {
                tiposCombustibleForm = new TiposCombustibleForm();
                tiposCombustibleForm.Show();
            } else
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
            } else
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
    }
}
