using System;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class ProductosRegistro : Form
	{
		PostgreSQL sql = new PostgreSQL();

		public ProductosRegistro()
		{

			InitializeComponent();
			sql.Conectar();

			textBoxID.Text = (sql.UltimoID("producto") + 1).ToString();

		}

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
			if (textBoxNombre.Text == "" || textBoxDescripcion.Text == "" || numericUpDownPrecio.Value == 0)
			{
				MessageBox.Show("Por favor ingresa todos los datos solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				sql.RegistrarProducto(textBoxNombre.Text, textBoxDescripcion.Text, numericUpDownPrecio.Value.ToString(), "0");
				textBoxNombre.Text = "";
				textBoxDescripcion.Text = "";
				numericUpDownPrecio.Value = 0;
				textBoxID.Text = (sql.UltimoID("producto") + 1).ToString();

			}
		}
    }
}
