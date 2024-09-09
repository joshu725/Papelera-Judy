using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class VentasRegistro : Form
	{
		PostgreSQL sql = new PostgreSQL();
		decimal subtotal = 0;

		public VentasRegistro()
		{

			InitializeComponent();
			sql.Conectar();

			grid.Columns.Add("IDProducto", "ID Producto");
			grid.Columns.Add("Descripcion", "Descripción del producto");
			grid.Columns.Add("Precio", "Precio unitario");
			grid.Columns.Add("Cantidad", "Cantidad");
			grid.Columns.Add("Importe", "Importe");

			grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
			grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			grid.AllowUserToOrderColumns = true;
			grid.AllowUserToResizeColumns = true;

			textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
			textBoxIDventa.Text = (sql.UltimoID("venta") + 1).ToString();

		}

        private void textBoxIDempleado_TextChanged(object sender, EventArgs e)
        {
			if(textBoxIDempleado.Text != "")
            {
				DataTable auxiliar = new DataTable();
				auxiliar = sql.ConsultarID("empleado", textBoxIDempleado.Text);

				if (auxiliar.Rows.Count != 0)
                {
					textBoxNombreEmpleado.Text = auxiliar.Rows[0][1].ToString();
				}
                else
                {
					textBoxNombreEmpleado.Text = "";
				}
            }
            else
            {
				textBoxNombreEmpleado.Text = "";
			}
		}

        private void textBoxIDempleado_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
		}

        private void textBoxIDcliente_TextChanged(object sender, EventArgs e)
        {
			if (textBoxIDcliente.Text != "")
			{
				DataTable auxiliar = new DataTable();
				auxiliar = sql.ConsultarID("cliente", textBoxIDcliente.Text);

				if (auxiliar.Rows.Count != 0)
				{
					textBoxNombreCliente.Text = auxiliar.Rows[0][1].ToString();
				}
				else
				{
					textBoxNombreCliente.Text = "";
				}
			}
			else
			{
				textBoxNombreCliente.Text = "";
			}
		}

        private void textBoxIDcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
		}

        private void textBoxIDproducto_TextChanged(object sender, EventArgs e)
        {
			if (textBoxIDproducto.Text != "")
			{
				DataTable auxiliar = new DataTable();
				auxiliar = sql.ConsultarID("producto", textBoxIDproducto.Text);

				if (auxiliar.Rows.Count != 0)
				{
					textBoxDescripcion.Text = auxiliar.Rows[0][1].ToString() + ", " + auxiliar.Rows[0][2].ToString();
					textBoxPrecio.Text = auxiliar.Rows[0][3].ToString();
				}
				else
				{
					textBoxDescripcion.Text = "";
					textBoxPrecio.Text = "";
				}
			}
			else
			{
				textBoxDescripcion.Text = "";
				textBoxPrecio.Text = "";
			}
		}

        private void textBoxIDproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
			e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
		}

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
			if (textBoxDescripcion.Text == "" && textBoxPrecio.Text == "")
            {
				MessageBox.Show("Por favor ingresa el ID de un producto registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
				if(numericUpDownCantidad.Value <= 0)
                {
					MessageBox.Show("Por favor ingresa una cantidad del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

					DataTable auxiliar = new DataTable();
					auxiliar = sql.ConsultarID("producto", textBoxIDproducto.Text);
					//
					decimal cantidadTotal = numericUpDownCantidad.Value;

					foreach (DataGridViewRow row in grid.Rows)
					{
						if (row.Cells[0].Value.ToString().Equals(textBoxIDproducto.Text))
						{
							cantidadTotal = numericUpDownCantidad.Value + decimal.Parse(row.Cells[3].Value.ToString());
							break;
						}
					}
					//
					if (cantidadTotal > decimal.Parse(auxiliar.Rows[0][4].ToString())){
						MessageBox.Show("La cantidad ingresada supera la existencia del producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						numericUpDownCantidad.Value = 0;
					}
                    else
                    {
						DataGridViewRow fila = new DataGridViewRow();
						int repetido = 0;
						subtotal = 0;

						fila.CreateCells(grid);
						fila.Cells[0].Value = textBoxIDproducto.Text;
						fila.Cells[1].Value = textBoxDescripcion.Text;
						fila.Cells[2].Value = textBoxPrecio.Text;


						fila.Cells[3].Value = numericUpDownCantidad.Value.ToString();

						foreach (DataGridViewRow row in grid.Rows)
						{
							if (row.Cells[0].Value.ToString().Equals(textBoxIDproducto.Text))
							{
								row.Cells[3].Value = (decimal.Add(numericUpDownCantidad.Value, decimal.Parse(row.Cells[3].Value.ToString()))).ToString();
								row.Cells[4].Value = (decimal.Multiply(decimal.Parse(row.Cells[3].Value.ToString()), decimal.Parse(row.Cells[2].Value.ToString()))).ToString();
								repetido = 1;
								break;
							}
						}

						if (repetido == 0)
						{
							fila.Cells[4].Value = (decimal.Multiply(decimal.Parse(fila.Cells[3].Value.ToString()), decimal.Parse(textBoxPrecio.Text))).ToString();

							grid.Rows.Add(fila);
							grid.ClearSelection();
						}
						else
						{
							grid.Update();
							grid.ClearSelection();

							foreach (DataGridViewRow row in grid.Rows)
							{
								subtotal = decimal.Add(subtotal, decimal.Parse(row.Cells[4].Value.ToString()));
							}

							textBoxSubtotal.Text = subtotal.ToString("F");

							repetido = 0;
						}

						textBoxIDproducto.Text = "";
						numericUpDownCantidad.Value = 0;

					}
				}
            }
        }

        private void textBoxSubtotal_TextChanged(object sender, EventArgs e)
        {
			
			//-----------------Iva

			string porcentaje = "";
			DateTime fecha = DateTime.Parse(textBoxFecha.Text);
			DateTime fechaIVA;

			DataTable auxiliar = new DataTable();
			auxiliar = sql.Consultar("iva");
			int indice = 0;
			foreach (DataRow row in auxiliar.Rows)
			{
				fechaIVA = DateTime.Parse(auxiliar.Rows[indice][2].ToString());

				if (fecha >= fechaIVA)
				{
					porcentaje = row[1].ToString();
				}

				indice = indice + 1;
			}
			porcentaje = "0." + porcentaje;

			//-----------------Iva

			textBoxIVA.Text = (decimal.Multiply(subtotal, decimal.Parse(porcentaje))).ToString("F");
			textBoxTotal.Text = (decimal.Add(subtotal, decimal.Parse(textBoxIVA.Text))).ToString("F");
        }

		private void buttonDisminuir_Click(object sender, EventArgs e)
		{
			if (textBoxDescripcion.Text == "" && textBoxPrecio.Text == "")
			{
				MessageBox.Show("Por favor ingresa el ID del producto a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
				int contador = 0;
				int bandera = 0;
				foreach (DataGridViewRow row in grid.Rows)
				{
					if(textBoxIDproducto.Text == row.Cells[0].Value.ToString())
                    {
						grid.Rows.RemoveAt(contador);
						grid.Update();
						bandera = 1;
                    }
					contador = contador + 1;
				}

				if(bandera != 1)
                {
					MessageBox.Show("El producto que intentas eliminar no se ha agregado a la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					bandera = 0;
				}
				
			}
			textBoxIDproducto.Text = "";
			numericUpDownCantidad.Value = 0;
		}

		private void buttonRegistrar_Click(object sender, EventArgs e)
        {
			if(textBoxNombreEmpleado.Text == "" || textBoxNombreCliente.Text == "" || grid.Rows.Count == 0)
            {
				MessageBox.Show("Por favor ingresa todos los datos solicitados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
				sql.RegistrarVenta(textBoxIDcliente.Text, textBoxIDempleado.Text, textBoxFecha.Text);

				foreach (DataGridViewRow row in grid.Rows)
				{
					sql.RegistrarDetalleVenta(textBoxIDventa.Text, row.Cells[0].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[2].Value.ToString());
					sql.RestarCantidadProducto(row.Cells[0].Value.ToString(), row.Cells[3].Value.ToString());
				}

				textBoxFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
				textBoxIDventa.Text = (sql.UltimoID("venta") + 1).ToString();
				textBoxIDempleado.Text = "";
				textBoxIDcliente.Text = "";
				textBoxIDproducto.Text = "";
				numericUpDownCantidad.Value = 0;
				textBoxSubtotal.Text = "";
				subtotal = 0;
				textBoxIVA.Text = "";
				textBoxTotal.Text = "";
				grid.Rows.Clear();
				grid.Update();

				MessageBox.Show("La venta número "+ sql.UltimoID("venta") + " ha sido registrada correctamente.", "Venta registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
        }

        private void grid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
			subtotal = 0;
			foreach (DataGridViewRow row in grid.Rows)
			{
				subtotal = decimal.Add(subtotal, decimal.Parse(row.Cells[4].Value.ToString()));
			}

			textBoxSubtotal.Text = subtotal.ToString("F");
		}

        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
			subtotal = 0;
			foreach (DataGridViewRow row in grid.Rows)
			{
				subtotal = decimal.Add(subtotal, decimal.Parse(row.Cells[4].Value.ToString()));
			}

			textBoxSubtotal.Text = subtotal.ToString("F");
		}
    }
}
