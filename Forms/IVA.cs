using System;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class IVA : Form
	{
		PostgreSQL sql = new PostgreSQL();

		public IVA()
		{

			InitializeComponent();
			sql.Conectar();

			grid.DataSource = sql.Consultar("iva");

			grid.Columns[0].HeaderText = "ID";
			grid.Columns[1].HeaderText = "Porcentaje";
			grid.Columns[2].HeaderText = "Fecha de aplicación";

			grid.AllowUserToOrderColumns = true;
			grid.AllowUserToResizeColumns = true;
		}

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
			if (numericUpDownIVA.Value == 0)
			{
				MessageBox.Show("Por favor ingresa un porcentaje.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				sql.RegistrarIVA(numericUpDownIVA.Value.ToString(), DateTime.Now.ToString("d/M/yyyy"));
				numericUpDownIVA.Value = 0;
				grid.DataSource = sql.Consultar("iva");
			}
		}

        private void IVA_Load(object sender, EventArgs e)
        {
			grid.ClearSelection();
        }
    }
}
