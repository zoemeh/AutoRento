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
            cliente.Cedula = cedulaText.Text.Replace("-","").Trim();
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
                if (Validar())
                {
                    clienteRepo.Update(FillCliente());
                    Close();
                }
            }
            else
            {
                if (Validar())
                {
                    clienteRepo.Create(FillCliente());
                    Close();
                }
            }
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
            if (string.IsNullOrWhiteSpace(tipoPersonaCombo.Text))
            {
                errores.Add("Tipo de persona no puede estar en blanco");
            }
            if (tipoPersonaCombo.Text == "Fisica")
            {
                if (!validaCedula(cedulaText.Text.Replace("-","").Trim()))
                {
                    errores.Add("Cedula no valida");
                }

            } else if (tipoPersonaCombo.Text == "Juridica")
            {
                if (!esUnRNCValido(cedulaText.Text.Trim())) {
                    errores.Add("RNC no valido");
                }
            }
            using AutoRentoContext db = new AutoRentoContext();
            if (db.Empleados.Where(x => x.Nombre == nombreText.Text.Trim() && x.Id != cliente.Id).Any())
            {
                errores.Add("Ya existe un cliente con este nombre");
            }
            if (db.Empleados.Where(x => x.Cedula == cedulaText.Text.Replace("-","").Trim() && x.Id != cliente.Id).Any())
            {
                errores.Add("Ya existe un cliente con esta cedula.");
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

        public static bool validaCedula(string pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }
        private bool esUnRNCValido(string pRNC)

        {

            int vnTotal = 0;

            int[] digitoMult = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };

            string vcRNC = pRNC.Replace("-", "").Replace(" ", "");

            string vDigito = vcRNC.Substring(8, 1);

            if (vcRNC.Length.Equals(9))

                if (!"145".Contains(vcRNC.Substring(0, 1)))

                    return false;

            for (int vDig = 1; vDig <= 8; vDig++)

            {

                int vCalculo = Int32.Parse(vcRNC.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];

                vnTotal += vCalculo;

            }

            if (vnTotal % 11 == 0 && vDigito == "1" || vnTotal % 11 == 1 && vDigito == "1" ||

                (11 - (vnTotal % 11)).Equals(vDigito))

                return true;

            else

                return false;

        }
    }
}
