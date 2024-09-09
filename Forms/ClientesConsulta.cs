using System;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class ClientesConsulta : Form
	{
		PostgreSQL sql = new PostgreSQL();

		public ClientesConsulta()
		{
			InitializeComponent();
			sql.Conectar();

			grid.DataSource = sql.Consultar("cliente");
			

			grid.Columns[0].HeaderText = "ID";
			grid.Columns[1].HeaderText = "Nombre";
			grid.Columns[2].HeaderText = "Dirección";
			grid.Columns[3].HeaderText = "Teléfono";
			grid.Columns[4].HeaderText = "Correo";
			
			grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			grid.AllowUserToOrderColumns = true;
			grid.AllowUserToResizeColumns = true;



		}

        private void ClientesConsulta_Load(object sender, EventArgs e)
        {
			grid.ClearSelection();
		}

        private void textBox_TextChanged(object sender, EventArgs e)
        {
			grid.DataSource = sql.ConsultarCliente(textBox.Text);
			grid.ClearSelection();
		}

    }
}
