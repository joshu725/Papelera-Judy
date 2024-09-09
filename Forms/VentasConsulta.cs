using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class VentasConsulta : Form
	{
        PostgreSQL sql = new PostgreSQL();
        decimal subtotal = 0;

        public VentasConsulta()
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

		}

        private void textBoxIDventa_TextChanged(object sender, EventArgs e)
        {
			textBoxFecha.Text = "";

			textBoxIDempleado.Text = "";
			textBoxNombreEmpleado.Text = "";

			textBoxIDcliente.Text = "";
			textBoxNombreCliente.Text = "";

			grid.Rows.Clear();
			grid.Update();

			textBoxSubtotal.Text = "";
			textBoxIVA.Text = "";
			textBoxTotal.Text = "";

			if (textBoxIDventa.Text != "")
			{
				DataTable auxiliar = new DataTable();
				DataTable auxiliarVenta = new DataTable();
				DataTable auxiliarDetalleVentas = new DataTable();

				auxiliarVenta = sql.ConsultarID("venta", textBoxIDventa.Text);

				if (auxiliarVenta.Rows.Count != 0)
				{
					subtotal = 0;

					DateTime fecha = DateTime.Parse(auxiliarVenta.Rows[0][3].ToString());
					textBoxFecha.Text = fecha.ToString("dd/MM/yyyy");

					auxiliar = sql.ConsultarID("empleado", auxiliarVenta.Rows[0][2].ToString());
					textBoxIDempleado.Text = auxiliarVenta.Rows[0][2].ToString();
					textBoxNombreEmpleado.Text = auxiliar.Rows[0][1].ToString();

					auxiliar = sql.ConsultarID("cliente", auxiliarVenta.Rows[0][1].ToString());
					textBoxIDcliente.Text = auxiliarVenta.Rows[0][1].ToString();
					textBoxNombreCliente.Text = auxiliar.Rows[0][1].ToString();

					auxiliarDetalleVentas = sql.ConsultarDetalleVentas(textBoxIDventa.Text);

					foreach (DataRow row in auxiliarDetalleVentas.Rows)
					{
						
						DataGridViewRow fila = new DataGridViewRow();

						fila.CreateCells(grid);
						fila.Cells[0].Value = row[2].ToString(); //idproducto

						auxiliar = sql.ConsultarID("producto", row[2].ToString());
						fila.Cells[1].Value = auxiliar.Rows[0][1].ToString() + ", " + auxiliar.Rows[0][2].ToString(); //descripcion

						fila.Cells[2].Value = row[4].ToString();   //precio
						fila.Cells[3].Value = row[3].ToString();    //cantidad
						fila.Cells[4].Value = (decimal.Multiply(decimal.Parse(row[3].ToString()), decimal.Parse(row[4].ToString()))).ToString();    //importe

						grid.Rows.Add(fila);
					}

					foreach (DataGridViewRow row in grid.Rows)
					{
						subtotal = decimal.Add(subtotal, decimal.Parse(row.Cells[4].Value.ToString()));
					}

					textBoxSubtotal.Text = subtotal.ToString("F");

					//-----------------Iva

					string porcentaje = "";
					DateTime fechaIVA;

					auxiliar = sql.Consultar("iva");
					int indice = 0;
					foreach (DataRow row in auxiliar.Rows)
                    {
						fechaIVA = DateTime.Parse(auxiliar.Rows[indice][2].ToString());

						if(fecha >= fechaIVA)
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
			}
			grid.ClearSelection();
		}

        private void textBoxIDventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
        }
    }
}
