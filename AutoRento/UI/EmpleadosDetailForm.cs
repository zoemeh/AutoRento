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
    public partial class EmpleadosDetailForm : Form
    {
        public bool Editando;
        public Empleado empleado = new Empleado();
        public EmpleadoRepo empleadoRepo = new EmpleadoRepo();
        List<string> errores = new List<string>();
        public EmpleadosDetailForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {

        }

        public Empleado FillEmpleado()
        {
            empleado.Nombre = nombreText.Text.Trim();
            empleado.Cedula = cedulaText.Text.Trim();
            empleado.TandaLabor = tandaCombo.Text.Trim();
            empleado.PorcienteComision = Convert.ToDouble(comisionText.Value);
            empleado.FechaIngreso = IngresoDate.Value.Date;
            empleado.Estado = estadoCheck.Checked;

            return empleado;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (Editando)
                {
                    empleadoRepo.Update(FillEmpleado());
                }
                else
                {
                    empleadoRepo.Create(FillEmpleado());
                }
                Close();
            }
        }

        internal void FillForm()
        {
            nombreText.Text = empleado.Nombre;
            cedulaText.Text = empleado.Cedula;
            tandaCombo.Text = empleado.TandaLabor;
            comisionText.Value = Convert.ToDecimal(empleado.PorcienteComision);
            IngresoDate.Value = empleado.FechaIngreso;
            estadoCheck.Checked = empleado.Estado;

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
            // TODO: validar cedula
            using AutoRentoContext db = new AutoRentoContext();
            if (db.Empleados.Where(x => x.Nombre == nombreText.Text.Trim() && x.Id != empleado.Id).Any())
            {
                errores.Add("Ya existe un empleado con este nombre");
            }
            if (db.Empleados.Where(x => x.Cedula == cedulaText.Text.Trim() && x.Id != empleado.Id).Any())
            {
                errores.Add("Ya existe un empleado con esta cedula.");
            }
            if (comisionText.Value < 0)
            {
                errores.Add("Comision no puede ser menor a 0");
            }
            if (!validaCedula(cedulaText.Text.Replace("-","").Trim()))
            {
                errores.Add("Cedula no valida");
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
    }
}
