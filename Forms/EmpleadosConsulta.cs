using System;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class EmpleadosConsulta : Form
	{
		PostgreSQL sql = new PostgreSQL();
		public EmpleadosConsulta()
		{

			InitializeComponent();

			sql.Conectar();

			grid.DataSource = sql.Consultar("empleado");


			grid.Columns[0].HeaderText = "ID";
			grid.Columns[1].HeaderText = "Nombre";
			grid.Columns[2].HeaderText = "Cargo";
			grid.Columns[3].HeaderText = "Dirección";
			grid.Columns[4].HeaderText = "Teléfono";
			grid.Columns[5].HeaderText = "Sexo";
			grid.Columns[6].HeaderText = "Fecha de nacimiento";
			grid.Columns[7].HeaderText = "Status";

			grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			grid.AllowUserToOrderColumns = true;
			grid.AllowUserToResizeColumns = true;

		}

		private void EmpleadosConsulta_Load(object sender, EventArgs e)
		{
			grid.ClearSelection();
		}

		private void textBox_TextChanged(object sender, EventArgs e)
        {
			grid.DataSource = sql.ConsultarEmpleado(textBox.Text);
			grid.ClearSelection();
		}

        
    }
}
