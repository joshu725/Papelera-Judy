using System;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class ProductosConsulta : Form
	{

		PostgreSQL sql = new PostgreSQL();

		public ProductosConsulta()
		{

			InitializeComponent();

			sql.Conectar();

			grid.DataSource = sql.Consultar("producto");


			grid.Columns[0].HeaderText = "ID";
			grid.Columns[1].HeaderText = "Nombre";
			grid.Columns[2].HeaderText = "Descripción";
			grid.Columns[3].HeaderText = "Precio";
			grid.Columns[4].HeaderText = "Existencia";

			grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			grid.AllowUserToOrderColumns = true;
			grid.AllowUserToResizeColumns = true;

		}

        private void ProductosConsulta_Load(object sender, EventArgs e)
        {
			grid.ClearSelection();
		}

        private void textBox_TextChanged(object sender, EventArgs e)
        {
			grid.DataSource = sql.ConsultarProducto(textBox.Text);
			grid.ClearSelection();
		}
    }
}
