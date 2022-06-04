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
    public partial class ClientesDetailForm : Form
    {
        public bool Editando;
        public Cliente cliente = new Cliente();
        public ClienteRepo clienteRepo = new ClienteRepo();
        List<string> errores = new List<string>();
        public ClientesDetailForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {

        }

        public Cliente FillCliente()
        {
            cliente.Nombre = nombreText.Text.Trim();
            cliente.Cedula = cedulaText.Text.Trim();
            cliente.TarjetaCredito = tarjetaText.Text.Trim();
            cliente.LimiteCredito = Convert.ToDouble(limiteCreditoText.Value);
            cliente.TipoPersona = tipoPersonaCombo.Text;
            cliente.Estado = estadoCheck.Checked;
            return cliente;
        }

        public void FillForm()
        {
            nombreText.Text = cliente.Nombre;
            cedulaText.Text = cliente.Cedula;
            tarjetaText.Text = cliente.TarjetaCredito;
            limiteCreditoText.Value = Convert.ToDecimal(cliente.LimiteCredito);
            tipoPersonaCombo.Text = cliente.TipoPersona;
            estadoCheck.Checked = cliente.Estado;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Editando)
            {
                clienteRepo.Update(FillCliente());
            }
            else
            {
                clienteRepo.Create(FillCliente());
            }
            Close();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool Validar()
        {
            errores.Clear();
            if (string.IsNullOrWhiteSpace(nombreText.Text))
            {
                errores.Add("Nombre no puede estar en blanco");
            }
            if (string.IsNullOrWhiteSpace(cedulaText.Text))
            {
                errores.Add("Cedula no puede estar en blanco");
            }
            if (string.IsNullOrWhiteSpace(tarjetaText.Text))
            {
                errores.Add("Tarjet de credito no puede estar en blanco");
            }
            if (limiteCreditoText.Value < 0)
            {
                errores.Add("Limite de credito no puede ser menor a 0");
            }
            // TODO: validar cedula
            using AutoRentoContext db = new AutoRentoContext();
            if (db.Empleados.Where(x => x.Nombre == nombreText.Text.Trim()).Any())
            {
                errores.Add("Ya existe un empleado con este nombre");
            }
            if (db.Empleados.Where(x => x.Cedula == cedulaText.Text.Trim()).Any())
            {
                errores.Add("Ya existe un empleado con esta cedula.");
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
