using System;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class ProveedorRegistro : Form
	{
		PostgreSQL sql = new PostgreSQL();
		public ProveedorRegistro()
		{

			InitializeComponent();
			sql.Conectar();
			textBoxID.Text = (sql.UltimoID("proveedor") + 1).ToString();

		}

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
			if (textBoxNombre.Text == "" || textBoxNombreEmpresa.Text == "" || textBoxTelefono.Text == "" || textBoxCorreo.Text == "")
			{
				MessageBox.Show("Por favor ingresa todos los datos solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				sql.RegistrarProveedor(textBoxNombre.Text, textBoxNombreEmpresa.Text, textBoxTelefono.Text, textBoxCorreo.Text);
				textBoxNombre.Text = "";
				textBoxNombreEmpresa.Text = "";
				textBoxTelefono.Text = "";
				textBoxCorreo.Text = "";
				textBoxID.Text = (sql.UltimoID("proveedor") + 1).ToString();

			}
		}
    }
}
