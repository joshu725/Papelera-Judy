using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class EmpleadosModificacion : Form
	{
		PostgreSQL sql = new PostgreSQL();

		public EmpleadosModificacion()
		{

			InitializeComponent();
			sql.Conectar();

		}

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
			if (textBoxID.Text != "")
			{
				DataTable auxiliar = new DataTable();
				auxiliar = sql.ConsultarID("empleado", textBoxID.Text);

				if (auxiliar.Rows.Count != 0)
				{
					textBoxNombre.Text = auxiliar.Rows[0][1].ToString();
					textBoxCargo.Text = auxiliar.Rows[0][2].ToString();
					textBoxDireccion.Text = auxiliar.Rows[0][3].ToString();
					textBoxTelefono.Text = auxiliar.Rows[0][4].ToString();
					textBoxSexo.Text = auxiliar.Rows[0][5].ToString();

					DateTime fecha = DateTime.Parse(auxiliar.Rows[0][6].ToString());

					textBoxFecha.Text = fecha.ToString("dd/MM/yyyy");
					
					if (auxiliar.Rows[0][7].ToString() == "1")
					{
						comboBoxStatus.SelectedIndex = 0;
					}
					else
					{
						comboBoxStatus.SelectedIndex = 1;
					}

					textBoxNombre.BackColor = SystemColors.Window;
					textBoxCargo.BackColor = SystemColors.Window;
					textBoxDireccion.BackColor = SystemColors.Window;
					textBoxTelefono.BackColor = SystemColors.Window;
					textBoxSexo.BackColor = SystemColors.Window;
					textBoxFecha.BackColor = SystemColors.Window;
					comboBoxStatus.BackColor = SystemColors.Window;

					textBoxNombre.ReadOnly = false;
					textBoxCargo.ReadOnly = false;
					textBoxDireccion.ReadOnly = false;
					textBoxTelefono.ReadOnly = false;
					textBoxSexo.ReadOnly = false;
					textBoxFecha.ReadOnly = false;
					comboBoxStatus.Enabled = true;


				}
				else
				{
					textBoxNombre.Text = "";
					textBoxCargo.Text = "";
					textBoxDireccion.Text = "";
					textBoxTelefono.Text = "";
					textBoxSexo.Text = "";
					textBoxFecha.Text = "";
					comboBoxStatus.SelectedIndex = -1;


					textBoxNombre.BackColor = SystemColors.ScrollBar;
					textBoxCargo.BackColor = SystemColors.ScrollBar;
					textBoxDireccion.BackColor = SystemColors.ScrollBar;
					textBoxTelefono.BackColor = SystemColors.ScrollBar;
					textBoxSexo.BackColor = SystemColors.ScrollBar;
					textBoxFecha.BackColor = SystemColors.ScrollBar;
					comboBoxStatus.BackColor = SystemColors.ScrollBar;

					textBoxNombre.ReadOnly = true;
					textBoxCargo.ReadOnly = true;
					textBoxDireccion.ReadOnly = true;
					textBoxTelefono.ReadOnly = true;
					textBoxSexo.ReadOnly = true;
					textBoxFecha.ReadOnly = true;
					comboBoxStatus.Enabled = false;
				}
			}
			else
			{
				textBoxNombre.Text = "";
				textBoxCargo.Text = "";
				textBoxDireccion.Text = "";
				textBoxTelefono.Text = "";
				textBoxSexo.Text = "";
				textBoxFecha.Text = "";
				comboBoxStatus.SelectedIndex = -1;


				textBoxNombre.BackColor = SystemColors.ScrollBar;
				textBoxCargo.BackColor = SystemColors.ScrollBar;
				textBoxDireccion.BackColor = SystemColors.ScrollBar;
				textBoxTelefono.BackColor = SystemColors.ScrollBar;
				textBoxSexo.BackColor = SystemColors.ScrollBar;
				textBoxFecha.BackColor = SystemColors.ScrollBar;
				comboBoxStatus.BackColor = SystemColors.ScrollBar;

				textBoxNombre.ReadOnly = true;
				textBoxCargo.ReadOnly = true;
				textBoxDireccion.ReadOnly = true;
				textBoxTelefono.ReadOnly = true;
				textBoxSexo.ReadOnly = true;
				textBoxFecha.ReadOnly = true;
				comboBoxStatus.Enabled = false;
			}
		}

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
		}

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
			if (textBoxNombre.Text == "" || textBoxCargo.Text == "" || textBoxDireccion.Text == "" || textBoxTelefono.Text == "" || textBoxSexo.Text == "" || textBoxFecha.Text == "")
			{
				MessageBox.Show("Por favor ingresa todos los datos solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				if (comboBoxStatus.SelectedIndex == 0)
				{
					sql.ModificarEmpleado(textBoxID.Text, textBoxNombre.Text, textBoxCargo.Text, textBoxDireccion.Text, textBoxTelefono.Text, textBoxSexo.Text, textBoxFecha.Text, "1");
				}
				else
				{
					sql.ModificarEmpleado(textBoxID.Text, textBoxNombre.Text, textBoxCargo.Text, textBoxDireccion.Text, textBoxTelefono.Text, textBoxSexo.Text, textBoxFecha.Text, "0");
				}
				textBoxID.Text = "";
			}
		}
    }
}
