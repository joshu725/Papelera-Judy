using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class ClientesModificacion : Form
	{
		PostgreSQL sql = new PostgreSQL();

		public ClientesModificacion()
		{

			InitializeComponent();
			sql.Conectar();

		}

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
			if(textBoxID.Text != "")
            {
				DataTable auxiliar = new DataTable();
				auxiliar = sql.ConsultarID("cliente", textBoxID.Text);

				if (auxiliar.Rows.Count != 0)
				{
					textBoxNombre.Text = auxiliar.Rows[0][1].ToString();
					textBoxDireccion.Text = auxiliar.Rows[0][2].ToString();
					textBoxTelefono.Text = auxiliar.Rows[0][3].ToString();
					textBoxCorreo.Text = auxiliar.Rows[0][4].ToString();

					textBoxNombre.BackColor = SystemColors.Window;
					textBoxDireccion.BackColor = SystemColors.Window;
					textBoxTelefono.BackColor = SystemColors.Window;
					textBoxCorreo.BackColor = SystemColors.Window;

					textBoxNombre.ReadOnly = false;
					textBoxDireccion.ReadOnly = false;
					textBoxTelefono.ReadOnly = false;
					textBoxCorreo.ReadOnly = false;
				}
                else
                {
					textBoxNombre.Text = "";
					textBoxDireccion.Text = "";
					textBoxTelefono.Text = "";
					textBoxCorreo.Text = "";

					textBoxNombre.BackColor = SystemColors.ScrollBar;
					textBoxDireccion.BackColor = SystemColors.ScrollBar;
					textBoxTelefono.BackColor = SystemColors.ScrollBar;
					textBoxCorreo.BackColor = SystemColors.ScrollBar;

					textBoxNombre.ReadOnly = true;
					textBoxDireccion.ReadOnly = true;
					textBoxTelefono.ReadOnly = true;
					textBoxCorreo.ReadOnly = true;
				}
			}
            else
            {
				textBoxNombre.Text = "";
				textBoxDireccion.Text = "";
				textBoxTelefono.Text = "";
				textBoxCorreo.Text = "";

				textBoxNombre.BackColor = SystemColors.ScrollBar;
				textBoxDireccion.BackColor = SystemColors.ScrollBar;
				textBoxTelefono.BackColor = SystemColors.ScrollBar;
				textBoxCorreo.BackColor = SystemColors.ScrollBar;

				textBoxNombre.ReadOnly = true;
				textBoxDireccion.ReadOnly = true;
				textBoxTelefono.ReadOnly = true;
				textBoxCorreo.ReadOnly = true;
			}
			
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
		}

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
			if (textBoxNombre.Text == "" || textBoxDireccion.Text == "" || textBoxTelefono.Text == "" || textBoxCorreo.Text == "")
			{
				MessageBox.Show("Por favor ingresa todos los datos solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				sql.ModificarCliente(textBoxID.Text, textBoxNombre.Text, textBoxDireccion.Text, textBoxTelefono.Text, textBoxCorreo.Text);
				textBoxID.Text = "";

			}
		}
    }
}
