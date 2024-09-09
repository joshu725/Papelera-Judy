using System;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class ClientesRegistro : Form
	{
		PostgreSQL sql = new PostgreSQL();
		public ClientesRegistro()
		{

			InitializeComponent();
			sql.Conectar();

			textBoxID.Text = (sql.UltimoID("cliente") + 1).ToString();

		}

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
			if(textBoxNombre.Text == "" || textBoxDireccion.Text == "" || textBoxTelefono.Text == "" || textBoxCorreo.Text == "")
            {
				MessageBox.Show("Por favor ingresa todos los datos solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
				sql.RegistrarCliente(textBoxNombre.Text, textBoxDireccion.Text, textBoxTelefono.Text, textBoxCorreo.Text);
				textBoxNombre.Text = "";
				textBoxDireccion.Text = "";
				textBoxTelefono.Text = "";
				textBoxCorreo.Text = "";
				textBoxID.Text = (sql.UltimoID("cliente") + 1).ToString();

			}
        }
    }
}
