using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class ProductosModificacion : Form
	{
		PostgreSQL sql = new PostgreSQL();

		public ProductosModificacion()
		{

			InitializeComponent();
			sql.Conectar();

		}

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
			if (textBoxID.Text != "")
			{
				DataTable auxiliar = new DataTable();
				auxiliar = sql.ConsultarID("producto", textBoxID.Text);

				if (auxiliar.Rows.Count != 0)
				{
					textBoxNombre.Text = auxiliar.Rows[0][1].ToString();
					textBoxDescripcion.Text = auxiliar.Rows[0][2].ToString();
					numericUpDownPrecio.Value = decimal.Parse(auxiliar.Rows[0][3].ToString());
					numericUpDownExistencia.Value = decimal.Parse(auxiliar.Rows[0][4].ToString());

					textBoxNombre.BackColor = SystemColors.Window;
					textBoxDescripcion.BackColor = SystemColors.Window;
					numericUpDownPrecio.BackColor = SystemColors.Window;
					numericUpDownExistencia.BackColor = SystemColors.Window;

					textBoxNombre.ReadOnly = false;
					textBoxDescripcion.ReadOnly = false;
					numericUpDownPrecio.ReadOnly = false;
					numericUpDownExistencia.ReadOnly = false;
				}
				else
				{
					textBoxNombre.Text = "";
					textBoxDescripcion.Text = "";
					numericUpDownPrecio.Value = 0;
					numericUpDownExistencia.Value = 0;

					textBoxNombre.BackColor = SystemColors.ScrollBar;
					textBoxDescripcion.BackColor = SystemColors.ScrollBar;
					numericUpDownPrecio.BackColor = SystemColors.ScrollBar;
					numericUpDownExistencia.BackColor = SystemColors.ScrollBar;

					textBoxNombre.ReadOnly = true;
					textBoxDescripcion.ReadOnly = true;
					numericUpDownPrecio.ReadOnly = true;
					numericUpDownExistencia.ReadOnly = true;
				}
			}
			else
			{
				textBoxNombre.Text = "";
				textBoxDescripcion.Text = "";
				numericUpDownPrecio.Value = 0;
				numericUpDownExistencia.Value = 0;

				textBoxNombre.BackColor = SystemColors.ScrollBar;
				textBoxDescripcion.BackColor = SystemColors.ScrollBar;
				numericUpDownPrecio.BackColor = SystemColors.ScrollBar;
				numericUpDownExistencia.BackColor = SystemColors.ScrollBar;

				textBoxNombre.ReadOnly = true;
				textBoxDescripcion.ReadOnly = true;
				numericUpDownPrecio.ReadOnly = true;
				numericUpDownExistencia.ReadOnly = true;
			}
		}

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
		}

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
			if (textBoxNombre.Text == "" || textBoxDescripcion.Text == "" || numericUpDownPrecio.Value == 0)
			{
				MessageBox.Show("Por favor ingresa todos los datos solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				sql.ModificarProducto(textBoxID.Text, textBoxNombre.Text, textBoxDescripcion.Text, numericUpDownPrecio.Value.ToString(), numericUpDownExistencia.Value.ToString());
				textBoxID.Text = "";

			}
		}
    }
}
