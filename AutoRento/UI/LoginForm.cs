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
    public partial class LoginForm : Form
    {
        private Usuario? usuario = null;
        readonly UsuarioRepo usuarioRepo = new UsuarioRepo();
        public LoginForm()
        {
            InitializeComponent();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            using AutoRentoContext db = new AutoRentoContext();
            usuario = db.Usuarios.Where(u => u.nombre == usuarioText.Text.Trim() && u.password == passwordText.Text.Trim()).FirstOrDefault();
            if (usuario == null)
            {
                MessageBox.Show("Usuario incorrecto.");
            } else
            {
                Close();
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (usuario == null)
            {
                Application.Exit();
            }
        }
    }
}
