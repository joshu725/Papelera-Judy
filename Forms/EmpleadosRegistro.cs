using System;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class EmpleadosRegistro : Form
	{
		PostgreSQL sql = new PostgreSQL();

		public EmpleadosRegistro()
		{

			InitializeComponent();
			sql.Conectar();
			textBoxID.Text = (sql.UltimoID("empleado") + 1).ToString();

		}

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
			if (textBoxNombre.Text == "" || textBoxCargo.Text == "" || textBoxDireccion.Text == "" || textBoxTelefono.Text == "" || textBoxSexo.Text == "" || textBoxFecha.Text == "")
			{
				MessageBox.Show("Por favor ingresa todos los datos solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				sql.RegistrarEmpleado(textBoxNombre.Text, textBoxCargo.Text, textBoxDireccion.Text, textBoxTelefono.Text, textBoxSexo.Text, textBoxFecha.Text, "1");
				textBoxNombre.Text = "";
				textBoxCargo.Text = "";
				textBoxDireccion.Text = "";
				textBoxTelefono.Text = "";
				textBoxSexo.Text = "";
				textBoxFecha.Text = "";
				textBoxID.Text = (sql.UltimoID("empleado") + 1).ToString();

			}
		}
    }
}
