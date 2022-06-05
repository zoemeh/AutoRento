using AutoRento.Data;
using AutoRento.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class ConsultaForm : Form
    {
        public ConsultaForm()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            clientesCombo.DataSource = (new ClienteRepo()).View();
            tipoVehiculoCombo.DataSource = (new TipoVehiculoRepo()).View();
            marcaCombo.DataSource = (new MarcaRepo()).View();
            modeloCombo.Enabled = false;
            clientesCombo.Enabled = false;
            tipoVehiculoCombo.Enabled = false;
            marcaCombo.Enabled = false;
            clienteCheck.Checked = false;
            tipoVehiculoCheck.Checked = false;
            marcaCheck.Checked = false;
            modeloCheck.Checked = false;
        }
        private void buscarBtn_Click_1(object sender, EventArgs e)
        {
            using AutoRentoContext db = new AutoRentoContext();
            var query = db.Rentas.Include(x => x.Empleado).Include(x => x.Vehiculo).Include(x => x.Cliente)
                .Where(x => x.FechaRenta >= desdeDate.Value && x.FechaRenta <= hastaDate.Value);
            if (clienteCheck.Checked)
            {
                query = query.Where(x => x.ClienteId == ((Cliente)clientesCombo.SelectedItem).Id);
            }
            if (tipoVehiculoCheck.Checked)
            {
                query = query.Where(x => x.Vehiculo.TipoVehiculoId == ((TipoVehiculo)tipoVehiculoCombo.SelectedItem).Id);
            }
            if (marcaCheck.Checked)
            {
                query = query.Where(x => x.Vehiculo.MarcaId == ((Marca)marcaCombo.SelectedItem).Id);
            }
            if (modeloCheck.Checked)
            {
                query = query.Where(x => x.Vehiculo.ModeloId == ((Modelo)modeloCombo.SelectedItem).Id);

            }
            var rentas = query.ToList();
            dataGridView1.DataSource = rentas;
        }
    }
}
