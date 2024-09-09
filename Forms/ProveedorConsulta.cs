using System;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class ProveedorConsulta : Form
	{
		PostgreSQL sql = new PostgreSQL();
		public ProveedorConsulta()
		{

			InitializeComponent();

			sql.Conectar();

			grid.DataSource = sql.Consultar("proveedor");


			grid.Columns[0].HeaderText = "ID";
			grid.Columns[1].HeaderText = "Nombre";
			grid.Columns[2].HeaderText = "Nombre de empresa";
			grid.Columns[3].HeaderText = "Teléfono";
			grid.Columns[4].HeaderText = "Correo";

			grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			grid.AllowUserToOrderColumns = true;
			grid.AllowUserToResizeColumns = true;

		}

        private void ProveedorConsulta_Load(object sender, EventArgs e)
        {
			grid.ClearSelection();
		}

        private void textBox_TextChanged(object sender, EventArgs e)
        {
			grid.DataSource = sql.ConsultarProveedor(textBox.Text);
			grid.ClearSelection();
		}
    }
}
