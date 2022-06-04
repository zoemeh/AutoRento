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
    }
}
