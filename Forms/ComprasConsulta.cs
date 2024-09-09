using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class ComprasConsulta : Form
	{
		PostgreSQL sql = new PostgreSQL();
		decimal subtotal = 0;

		public ComprasConsulta()
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

		private void textBoxIDcompra_TextChanged(object sender, EventArgs e)
		{
			textBoxFecha.Text = "";

			textBoxIDempleado.Text = "";
			textBoxNombreEmpleado.Text = "";

			textBoxIDproveedor.Text = "";
			textBoxNombreProveedor.Text = "";

			grid.Rows.Clear();
			grid.Update();

			textBoxSubtotal.Text = "";
			textBoxIVA.Text = "";
			textBoxTotal.Text = "";

			if (textBoxIDcompra.Text != "")
			{
				DataTable auxiliar = new DataTable();
				DataTable auxiliarCompra = new DataTable();
				DataTable auxiliarDetalleCompras = new DataTable();

				auxiliarCompra = sql.ConsultarID("compra", textBoxIDcompra.Text);

				if (auxiliarCompra.Rows.Count != 0)
				{
					subtotal = 0;

					DateTime fecha = DateTime.Parse(auxiliarCompra.Rows[0][3].ToString());
					textBoxFecha.Text = fecha.ToString("dd/MM/yyyy");

					auxiliar = sql.ConsultarID("empleado", auxiliarCompra.Rows[0][2].ToString());
					textBoxIDempleado.Text = auxiliarCompra.Rows[0][2].ToString();
					textBoxNombreEmpleado.Text = auxiliar.Rows[0][1].ToString() + " " + auxiliar.Rows[0][2].ToString();

					auxiliar = sql.ConsultarID("proveedor", auxiliarCompra.Rows[0][1].ToString());
					textBoxIDproveedor.Text = auxiliarCompra.Rows[0][1].ToString();
					textBoxNombreProveedor.Text = auxiliar.Rows[0][2].ToString();

					auxiliarDetalleCompras = sql.ConsultarDetalleCompras(textBoxIDcompra.Text);

					foreach (DataRow row in auxiliarDetalleCompras.Rows)
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
			}
			grid.ClearSelection();
		}

		private void textBoxIDcompra_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
		}
	}
}
