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
    }
}
