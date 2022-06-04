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
            if (db.Empleados.Where(x => x.Nombre == nombreText.Text.Trim()).Any())
            {
                errores.Add("Ya existe un empleado con este nombre");
            }
            if (db.Empleados.Where(x => x.Cedula == cedulaText.Text.Trim()).Any())
            {
                errores.Add("Ya existe un empleado con esta cedula.");
            }
            if (comisionText.Value < 0)
            {
                errores.Add("Comision no puede ser menor a 0");
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
