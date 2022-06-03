using AutoRento.Models;
using AutoRento.UI;

namespace AutoRento
{
    public partial class TiposCombustibleForm : Form
    {
        readonly TipoCombustible tipoCombustible = new TipoCombustible();
        readonly TipoCombustibleRepo tipoCombustibleRepo = new TipoCombustibleRepo();
        public TiposCombustibleForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void LoadData()
        {
            CombustiblesGrid.DataSource = tipoCombustibleRepo.View();
            CombustiblesGrid.ClearSelection();
        }

        private TipoCombustible GetTipoCombustible()
        {
            tipoCombustible.Descripcion = descripcionText.Text.Trim();
            tipoCombustible.Estado = estadoCheck.Checked;
            return tipoCombustible;
        }

        private void  Clear()
        {
            descripcionText.Text = "";
            estadoCheck.Checked = false;
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            tipoCombustibleRepo.Create(GetTipoCombustible());
            LoadData();
            Clear();
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            tipoCombustibleRepo.Update(GetTipoCombustible());
            LoadData();
            Clear();
        }

        private void CombustiblesGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tipoCombustible.Id = Convert.ToInt32(CombustiblesGrid.SelectedRows[0].Cells[0].Value.ToString());
            tipoCombustible.Descripcion = CombustiblesGrid.SelectedRows[0].Cells[1].Value.ToString();
            tipoCombustible.Estado = Convert.ToBoolean(CombustiblesGrid.SelectedRows[0].Cells[2].Value.ToString());
            descripcionText.Text = tipoCombustible.Descripcion;
            estadoCheck.Checked = tipoCombustible.Estado;
        }
        private void borrarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var t = GetTipoCombustible();
                if (t != null)
                {
                    tipoCombustibleRepo.Delete(t);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void CombustiblesGrid_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}