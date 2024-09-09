/*
 * Creado por SharpDevelop.
 * Usuario: Josh
 * Fecha: 11/7/2021
 * Hora: 9:46 AM
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PapeleraJudy
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenuLateral = new Panel();
            buttonIVA = new Button();
            panelEmpleadosSubmenu = new Panel();
            buttonEmpleadoConsulta = new Button();
            buttonEmpleadoModificacion = new Button();
            buttonEmpleadoRegistro = new Button();
            buttonEmpleados = new Button();
            panelProveedoresSubmenu = new Panel();
            buttonProveedorConsulta = new Button();
            buttonProveedorModificacion = new Button();
            buttonProveedorRegistro = new Button();
            buttonProveedores = new Button();
            panelProductosSubmenu = new Panel();
            buttonProductoConsulta = new Button();
            buttonProductoModificacion = new Button();
            buttonProductoRegistro = new Button();
            buttonProductos = new Button();
            panelClienteSubmenu = new Panel();
            buttonClienteConsulta = new Button();
            buttonClienteModificacion = new Button();
            buttonClienteRegistro = new Button();
            buttonClientes = new Button();
            panelComprasSubmenu = new Panel();
            buttonComprasConsulta = new Button();
            buttonCompraRegistro = new Button();
            buttonCompras = new Button();
            panelVentasSubmenu = new Panel();
            buttonVentaConsulta = new Button();
            buttonVentaRegistro = new Button();
            buttonVentas = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            panelMenuLateral.SuspendLayout();
            panelEmpleadosSubmenu.SuspendLayout();
            panelProveedoresSubmenu.SuspendLayout();
            panelProductosSubmenu.SuspendLayout();
            panelClienteSubmenu.SuspendLayout();
            panelComprasSubmenu.SuspendLayout();
            panelVentasSubmenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.FromArgb(17, 32, 49);
            panelMenuLateral.Controls.Add(buttonIVA);
            panelMenuLateral.Controls.Add(panelEmpleadosSubmenu);
            panelMenuLateral.Controls.Add(buttonEmpleados);
            panelMenuLateral.Controls.Add(panelProveedoresSubmenu);
            panelMenuLateral.Controls.Add(buttonProveedores);
            panelMenuLateral.Controls.Add(panelProductosSubmenu);
            panelMenuLateral.Controls.Add(buttonProductos);
            panelMenuLateral.Controls.Add(panelClienteSubmenu);
            panelMenuLateral.Controls.Add(buttonClientes);
            panelMenuLateral.Controls.Add(panelComprasSubmenu);
            panelMenuLateral.Controls.Add(buttonCompras);
            panelMenuLateral.Controls.Add(panelVentasSubmenu);
            panelMenuLateral.Controls.Add(buttonVentas);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Margin = new Padding(4, 3, 4, 3);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(229, 786);
            panelMenuLateral.TabIndex = 0;
            // 
            // buttonIVA
            // 
            buttonIVA.Dock = DockStyle.Top;
            buttonIVA.FlatAppearance.BorderSize = 0;
            buttonIVA.FlatStyle = FlatStyle.Flat;
            buttonIVA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIVA.ForeColor = Color.WhiteSmoke;
            buttonIVA.Image = Papelera_Judy.Properties.Resources.iva;
            buttonIVA.ImageAlign = ContentAlignment.MiddleLeft;
            buttonIVA.Location = new Point(0, 1195);
            buttonIVA.Margin = new Padding(4, 3, 4, 3);
            buttonIVA.Name = "buttonIVA";
            buttonIVA.Padding = new Padding(6, 0, 0, 0);
            buttonIVA.Size = new Size(212, 52);
            buttonIVA.TabIndex = 15;
            buttonIVA.Text = "  IVA";
            buttonIVA.TextAlign = ContentAlignment.MiddleLeft;
            buttonIVA.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonIVA.UseVisualStyleBackColor = true;
            buttonIVA.Click += ButtonIVAClick;
            // 
            // panelEmpleadosSubmenu
            // 
            panelEmpleadosSubmenu.BackColor = Color.FromArgb(21, 45, 53);
            panelEmpleadosSubmenu.Controls.Add(buttonEmpleadoConsulta);
            panelEmpleadosSubmenu.Controls.Add(buttonEmpleadoModificacion);
            panelEmpleadosSubmenu.Controls.Add(buttonEmpleadoRegistro);
            panelEmpleadosSubmenu.Dock = DockStyle.Top;
            panelEmpleadosSubmenu.Location = new Point(0, 1052);
            panelEmpleadosSubmenu.Margin = new Padding(4, 3, 4, 3);
            panelEmpleadosSubmenu.Name = "panelEmpleadosSubmenu";
            panelEmpleadosSubmenu.Size = new Size(212, 143);
            panelEmpleadosSubmenu.TabIndex = 14;
            // 
            // buttonEmpleadoConsulta
            // 
            buttonEmpleadoConsulta.Dock = DockStyle.Top;
            buttonEmpleadoConsulta.FlatAppearance.BorderSize = 0;
            buttonEmpleadoConsulta.FlatStyle = FlatStyle.Flat;
            buttonEmpleadoConsulta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEmpleadoConsulta.ForeColor = Color.Gainsboro;
            buttonEmpleadoConsulta.Location = new Point(0, 92);
            buttonEmpleadoConsulta.Margin = new Padding(4, 3, 4, 3);
            buttonEmpleadoConsulta.Name = "buttonEmpleadoConsulta";
            buttonEmpleadoConsulta.Padding = new Padding(64, 0, 0, 0);
            buttonEmpleadoConsulta.Size = new Size(212, 46);
            buttonEmpleadoConsulta.TabIndex = 2;
            buttonEmpleadoConsulta.Text = "Consultar empleado";
            buttonEmpleadoConsulta.TextAlign = ContentAlignment.MiddleLeft;
            buttonEmpleadoConsulta.UseVisualStyleBackColor = true;
            buttonEmpleadoConsulta.Click += ButtonEmpleadoConsultaClick;
            // 
            // buttonEmpleadoModificacion
            // 
            buttonEmpleadoModificacion.Dock = DockStyle.Top;
            buttonEmpleadoModificacion.FlatAppearance.BorderSize = 0;
            buttonEmpleadoModificacion.FlatStyle = FlatStyle.Flat;
            buttonEmpleadoModificacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEmpleadoModificacion.ForeColor = Color.Gainsboro;
            buttonEmpleadoModificacion.Location = new Point(0, 46);
            buttonEmpleadoModificacion.Margin = new Padding(4, 3, 4, 3);
            buttonEmpleadoModificacion.Name = "buttonEmpleadoModificacion";
            buttonEmpleadoModificacion.Padding = new Padding(64, 0, 0, 0);
            buttonEmpleadoModificacion.Size = new Size(212, 46);
            buttonEmpleadoModificacion.TabIndex = 1;
            buttonEmpleadoModificacion.Text = "Modificar empleado";
            buttonEmpleadoModificacion.TextAlign = ContentAlignment.MiddleLeft;
            buttonEmpleadoModificacion.UseVisualStyleBackColor = true;
            buttonEmpleadoModificacion.Click += ButtonEmpleadoModificacionClick;
            // 
            // buttonEmpleadoRegistro
            // 
            buttonEmpleadoRegistro.Dock = DockStyle.Top;
            buttonEmpleadoRegistro.FlatAppearance.BorderSize = 0;
            buttonEmpleadoRegistro.FlatStyle = FlatStyle.Flat;
            buttonEmpleadoRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEmpleadoRegistro.ForeColor = Color.Gainsboro;
            buttonEmpleadoRegistro.Location = new Point(0, 0);
            buttonEmpleadoRegistro.Margin = new Padding(4, 3, 4, 3);
            buttonEmpleadoRegistro.Name = "buttonEmpleadoRegistro";
            buttonEmpleadoRegistro.Padding = new Padding(64, 0, 0, 0);
            buttonEmpleadoRegistro.Size = new Size(212, 46);
            buttonEmpleadoRegistro.TabIndex = 0;
            buttonEmpleadoRegistro.Text = "Registrar empleado";
            buttonEmpleadoRegistro.TextAlign = ContentAlignment.MiddleLeft;
            buttonEmpleadoRegistro.UseVisualStyleBackColor = true;
            buttonEmpleadoRegistro.Click += ButtonEmpleadoRegistroClick;
            // 
            // buttonEmpleados
            // 
            buttonEmpleados.Dock = DockStyle.Top;
            buttonEmpleados.FlatAppearance.BorderSize = 0;
            buttonEmpleados.FlatStyle = FlatStyle.Flat;
            buttonEmpleados.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEmpleados.ForeColor = Color.WhiteSmoke;
            buttonEmpleados.Image = Papelera_Judy.Properties.Resources.empleado;
            buttonEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEmpleados.Location = new Point(0, 1000);
            buttonEmpleados.Margin = new Padding(4, 3, 4, 3);
            buttonEmpleados.Name = "buttonEmpleados";
            buttonEmpleados.Padding = new Padding(6, 0, 0, 0);
            buttonEmpleados.Size = new Size(212, 52);
            buttonEmpleados.TabIndex = 13;
            buttonEmpleados.Text = "  Empleados";
            buttonEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            buttonEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonEmpleados.UseVisualStyleBackColor = true;
            buttonEmpleados.Click += ButtonEmpleadosClick;
            // 
            // panelProveedoresSubmenu
            // 
            panelProveedoresSubmenu.BackColor = Color.FromArgb(21, 45, 53);
            panelProveedoresSubmenu.Controls.Add(buttonProveedorConsulta);
            panelProveedoresSubmenu.Controls.Add(buttonProveedorModificacion);
            panelProveedoresSubmenu.Controls.Add(buttonProveedorRegistro);
            panelProveedoresSubmenu.Dock = DockStyle.Top;
            panelProveedoresSubmenu.Location = new Point(0, 857);
            panelProveedoresSubmenu.Margin = new Padding(4, 3, 4, 3);
            panelProveedoresSubmenu.Name = "panelProveedoresSubmenu";
            panelProveedoresSubmenu.Size = new Size(212, 143);
            panelProveedoresSubmenu.TabIndex = 12;
            // 
            // buttonProveedorConsulta
            // 
            buttonProveedorConsulta.Dock = DockStyle.Top;
            buttonProveedorConsulta.FlatAppearance.BorderSize = 0;
            buttonProveedorConsulta.FlatStyle = FlatStyle.Flat;
            buttonProveedorConsulta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProveedorConsulta.ForeColor = Color.Gainsboro;
            buttonProveedorConsulta.Location = new Point(0, 92);
            buttonProveedorConsulta.Margin = new Padding(4, 3, 4, 3);
            buttonProveedorConsulta.Name = "buttonProveedorConsulta";
            buttonProveedorConsulta.Padding = new Padding(64, 0, 0, 0);
            buttonProveedorConsulta.Size = new Size(212, 46);
            buttonProveedorConsulta.TabIndex = 2;
            buttonProveedorConsulta.Text = "Consultar proveedor";
            buttonProveedorConsulta.TextAlign = ContentAlignment.MiddleLeft;
            buttonProveedorConsulta.UseVisualStyleBackColor = true;
            buttonProveedorConsulta.Click += ButtonProveedorConsultaClick;
            // 
            // buttonProveedorModificacion
            // 
            buttonProveedorModificacion.Dock = DockStyle.Top;
            buttonProveedorModificacion.FlatAppearance.BorderSize = 0;
            buttonProveedorModificacion.FlatStyle = FlatStyle.Flat;
            buttonProveedorModificacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProveedorModificacion.ForeColor = Color.Gainsboro;
            buttonProveedorModificacion.Location = new Point(0, 46);
            buttonProveedorModificacion.Margin = new Padding(4, 3, 4, 3);
            buttonProveedorModificacion.Name = "buttonProveedorModificacion";
            buttonProveedorModificacion.Padding = new Padding(64, 0, 0, 0);
            buttonProveedorModificacion.Size = new Size(212, 46);
            buttonProveedorModificacion.TabIndex = 1;
            buttonProveedorModificacion.Text = "Modificar proveedor";
            buttonProveedorModificacion.TextAlign = ContentAlignment.MiddleLeft;
            buttonProveedorModificacion.UseVisualStyleBackColor = true;
            buttonProveedorModificacion.Click += ButtonProveedorModificacionClick;
            // 
            // buttonProveedorRegistro
            // 
            buttonProveedorRegistro.Dock = DockStyle.Top;
            buttonProveedorRegistro.FlatAppearance.BorderSize = 0;
            buttonProveedorRegistro.FlatStyle = FlatStyle.Flat;
            buttonProveedorRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProveedorRegistro.ForeColor = Color.Gainsboro;
            buttonProveedorRegistro.Location = new Point(0, 0);
            buttonProveedorRegistro.Margin = new Padding(4, 3, 4, 3);
            buttonProveedorRegistro.Name = "buttonProveedorRegistro";
            buttonProveedorRegistro.Padding = new Padding(64, 0, 0, 0);
            buttonProveedorRegistro.Size = new Size(212, 46);
            buttonProveedorRegistro.TabIndex = 0;
            buttonProveedorRegistro.Text = "Registrar proveedor";
            buttonProveedorRegistro.TextAlign = ContentAlignment.MiddleLeft;
            buttonProveedorRegistro.UseVisualStyleBackColor = true;
            buttonProveedorRegistro.Click += ButtonProveedorRegistroClick;
            // 
            // buttonProveedores
            // 
            buttonProveedores.Dock = DockStyle.Top;
            buttonProveedores.FlatAppearance.BorderSize = 0;
            buttonProveedores.FlatStyle = FlatStyle.Flat;
            buttonProveedores.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProveedores.ForeColor = Color.WhiteSmoke;
            buttonProveedores.Image = Papelera_Judy.Properties.Resources.proveedores;
            buttonProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProveedores.Location = new Point(0, 805);
            buttonProveedores.Margin = new Padding(4, 3, 4, 3);
            buttonProveedores.Name = "buttonProveedores";
            buttonProveedores.Padding = new Padding(6, 0, 0, 0);
            buttonProveedores.Size = new Size(212, 52);
            buttonProveedores.TabIndex = 11;
            buttonProveedores.Text = "  Proveedores";
            buttonProveedores.TextAlign = ContentAlignment.MiddleLeft;
            buttonProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProveedores.UseVisualStyleBackColor = true;
            buttonProveedores.Click += ButtonProveedoresClick;
            // 
            // panelProductosSubmenu
            // 
            panelProductosSubmenu.BackColor = Color.FromArgb(21, 45, 53);
            panelProductosSubmenu.Controls.Add(buttonProductoConsulta);
            panelProductosSubmenu.Controls.Add(buttonProductoModificacion);
            panelProductosSubmenu.Controls.Add(buttonProductoRegistro);
            panelProductosSubmenu.Dock = DockStyle.Top;
            panelProductosSubmenu.Location = new Point(0, 662);
            panelProductosSubmenu.Margin = new Padding(4, 3, 4, 3);
            panelProductosSubmenu.Name = "panelProductosSubmenu";
            panelProductosSubmenu.Size = new Size(212, 143);
            panelProductosSubmenu.TabIndex = 10;
            // 
            // buttonProductoConsulta
            // 
            buttonProductoConsulta.Dock = DockStyle.Top;
            buttonProductoConsulta.FlatAppearance.BorderSize = 0;
            buttonProductoConsulta.FlatStyle = FlatStyle.Flat;
            buttonProductoConsulta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProductoConsulta.ForeColor = Color.Gainsboro;
            buttonProductoConsulta.Location = new Point(0, 92);
            buttonProductoConsulta.Margin = new Padding(4, 3, 4, 3);
            buttonProductoConsulta.Name = "buttonProductoConsulta";
            buttonProductoConsulta.Padding = new Padding(64, 0, 0, 0);
            buttonProductoConsulta.Size = new Size(212, 46);
            buttonProductoConsulta.TabIndex = 2;
            buttonProductoConsulta.Text = "Consultar producto";
            buttonProductoConsulta.TextAlign = ContentAlignment.MiddleLeft;
            buttonProductoConsulta.UseVisualStyleBackColor = true;
            buttonProductoConsulta.Click += ButtonProductoConsultaClick;
            // 
            // buttonProductoModificacion
            // 
            buttonProductoModificacion.Dock = DockStyle.Top;
            buttonProductoModificacion.FlatAppearance.BorderSize = 0;
            buttonProductoModificacion.FlatStyle = FlatStyle.Flat;
            buttonProductoModificacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProductoModificacion.ForeColor = Color.Gainsboro;
            buttonProductoModificacion.Location = new Point(0, 46);
            buttonProductoModificacion.Margin = new Padding(4, 3, 4, 3);
            buttonProductoModificacion.Name = "buttonProductoModificacion";
            buttonProductoModificacion.Padding = new Padding(64, 0, 0, 0);
            buttonProductoModificacion.Size = new Size(212, 46);
            buttonProductoModificacion.TabIndex = 1;
            buttonProductoModificacion.Text = "Modificar producto";
            buttonProductoModificacion.TextAlign = ContentAlignment.MiddleLeft;
            buttonProductoModificacion.UseVisualStyleBackColor = true;
            buttonProductoModificacion.Click += ButtonProductoModificacionClick;
            // 
            // buttonProductoRegistro
            // 
            buttonProductoRegistro.Dock = DockStyle.Top;
            buttonProductoRegistro.FlatAppearance.BorderSize = 0;
            buttonProductoRegistro.FlatStyle = FlatStyle.Flat;
            buttonProductoRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProductoRegistro.ForeColor = Color.Gainsboro;
            buttonProductoRegistro.Location = new Point(0, 0);
            buttonProductoRegistro.Margin = new Padding(4, 3, 4, 3);
            buttonProductoRegistro.Name = "buttonProductoRegistro";
            buttonProductoRegistro.Padding = new Padding(64, 0, 0, 0);
            buttonProductoRegistro.Size = new Size(212, 46);
            buttonProductoRegistro.TabIndex = 0;
            buttonProductoRegistro.Text = "Registrar producto";
            buttonProductoRegistro.TextAlign = ContentAlignment.MiddleLeft;
            buttonProductoRegistro.UseVisualStyleBackColor = true;
            buttonProductoRegistro.Click += ButtonProductoRegistroClick;
            // 
            // buttonProductos
            // 
            buttonProductos.Dock = DockStyle.Top;
            buttonProductos.FlatAppearance.BorderSize = 0;
            buttonProductos.FlatStyle = FlatStyle.Flat;
            buttonProductos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProductos.ForeColor = Color.WhiteSmoke;
            buttonProductos.Image = Papelera_Judy.Properties.Resources.productos;
            buttonProductos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProductos.Location = new Point(0, 610);
            buttonProductos.Margin = new Padding(4, 3, 4, 3);
            buttonProductos.Name = "buttonProductos";
            buttonProductos.Padding = new Padding(6, 0, 0, 0);
            buttonProductos.Size = new Size(212, 52);
            buttonProductos.TabIndex = 9;
            buttonProductos.Text = "  Productos";
            buttonProductos.TextAlign = ContentAlignment.MiddleLeft;
            buttonProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonProductos.UseVisualStyleBackColor = true;
            buttonProductos.Click += ButtonProductosClick;
            // 
            // panelClienteSubmenu
            // 
            panelClienteSubmenu.BackColor = Color.FromArgb(21, 45, 53);
            panelClienteSubmenu.Controls.Add(buttonClienteConsulta);
            panelClienteSubmenu.Controls.Add(buttonClienteModificacion);
            panelClienteSubmenu.Controls.Add(buttonClienteRegistro);
            panelClienteSubmenu.Dock = DockStyle.Top;
            panelClienteSubmenu.Location = new Point(0, 467);
            panelClienteSubmenu.Margin = new Padding(4, 3, 4, 3);
            panelClienteSubmenu.Name = "panelClienteSubmenu";
            panelClienteSubmenu.Size = new Size(212, 143);
            panelClienteSubmenu.TabIndex = 8;
            // 
            // buttonClienteConsulta
            // 
            buttonClienteConsulta.Dock = DockStyle.Top;
            buttonClienteConsulta.FlatAppearance.BorderSize = 0;
            buttonClienteConsulta.FlatStyle = FlatStyle.Flat;
            buttonClienteConsulta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClienteConsulta.ForeColor = Color.Gainsboro;
            buttonClienteConsulta.Location = new Point(0, 92);
            buttonClienteConsulta.Margin = new Padding(4, 3, 4, 3);
            buttonClienteConsulta.Name = "buttonClienteConsulta";
            buttonClienteConsulta.Padding = new Padding(64, 0, 0, 0);
            buttonClienteConsulta.Size = new Size(212, 46);
            buttonClienteConsulta.TabIndex = 2;
            buttonClienteConsulta.Text = "Consultar cliente";
            buttonClienteConsulta.TextAlign = ContentAlignment.MiddleLeft;
            buttonClienteConsulta.UseVisualStyleBackColor = true;
            buttonClienteConsulta.Click += ButtonClienteConsultaClick;
            // 
            // buttonClienteModificacion
            // 
            buttonClienteModificacion.Dock = DockStyle.Top;
            buttonClienteModificacion.FlatAppearance.BorderSize = 0;
            buttonClienteModificacion.FlatStyle = FlatStyle.Flat;
            buttonClienteModificacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClienteModificacion.ForeColor = Color.Gainsboro;
            buttonClienteModificacion.Location = new Point(0, 46);
            buttonClienteModificacion.Margin = new Padding(4, 3, 4, 3);
            buttonClienteModificacion.Name = "buttonClienteModificacion";
            buttonClienteModificacion.Padding = new Padding(64, 0, 0, 0);
            buttonClienteModificacion.Size = new Size(212, 46);
            buttonClienteModificacion.TabIndex = 1;
            buttonClienteModificacion.Text = "Modificar cliente";
            buttonClienteModificacion.TextAlign = ContentAlignment.MiddleLeft;
            buttonClienteModificacion.UseVisualStyleBackColor = true;
            buttonClienteModificacion.Click += ButtonClienteModificacionClick;
            // 
            // buttonClienteRegistro
            // 
            buttonClienteRegistro.Dock = DockStyle.Top;
            buttonClienteRegistro.FlatAppearance.BorderSize = 0;
            buttonClienteRegistro.FlatStyle = FlatStyle.Flat;
            buttonClienteRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClienteRegistro.ForeColor = Color.Gainsboro;
            buttonClienteRegistro.Location = new Point(0, 0);
            buttonClienteRegistro.Margin = new Padding(4, 3, 4, 3);
            buttonClienteRegistro.Name = "buttonClienteRegistro";
            buttonClienteRegistro.Padding = new Padding(64, 0, 0, 0);
            buttonClienteRegistro.Size = new Size(212, 46);
            buttonClienteRegistro.TabIndex = 0;
            buttonClienteRegistro.Text = "Registrar cliente";
            buttonClienteRegistro.TextAlign = ContentAlignment.MiddleLeft;
            buttonClienteRegistro.UseVisualStyleBackColor = true;
            buttonClienteRegistro.Click += ButtonClienteRegistroClick;
            // 
            // buttonClientes
            // 
            buttonClientes.Dock = DockStyle.Top;
            buttonClientes.FlatAppearance.BorderSize = 0;
            buttonClientes.FlatStyle = FlatStyle.Flat;
            buttonClientes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClientes.ForeColor = Color.WhiteSmoke;
            buttonClientes.Image = Papelera_Judy.Properties.Resources.clientes;
            buttonClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClientes.Location = new Point(0, 415);
            buttonClientes.Margin = new Padding(4, 3, 4, 3);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Padding = new Padding(6, 0, 0, 0);
            buttonClientes.Size = new Size(212, 52);
            buttonClientes.TabIndex = 7;
            buttonClientes.Text = "  Clientes";
            buttonClientes.TextAlign = ContentAlignment.MiddleLeft;
            buttonClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += ButtonClientesClick;
            // 
            // panelComprasSubmenu
            // 
            panelComprasSubmenu.BackColor = Color.FromArgb(21, 45, 53);
            panelComprasSubmenu.Controls.Add(buttonComprasConsulta);
            panelComprasSubmenu.Controls.Add(buttonCompraRegistro);
            panelComprasSubmenu.Dock = DockStyle.Top;
            panelComprasSubmenu.Location = new Point(0, 318);
            panelComprasSubmenu.Margin = new Padding(4, 3, 4, 3);
            panelComprasSubmenu.Name = "panelComprasSubmenu";
            panelComprasSubmenu.Size = new Size(212, 97);
            panelComprasSubmenu.TabIndex = 4;
            // 
            // buttonComprasConsulta
            // 
            buttonComprasConsulta.Dock = DockStyle.Top;
            buttonComprasConsulta.FlatAppearance.BorderSize = 0;
            buttonComprasConsulta.FlatStyle = FlatStyle.Flat;
            buttonComprasConsulta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonComprasConsulta.ForeColor = Color.Gainsboro;
            buttonComprasConsulta.Location = new Point(0, 46);
            buttonComprasConsulta.Margin = new Padding(4, 3, 4, 3);
            buttonComprasConsulta.Name = "buttonComprasConsulta";
            buttonComprasConsulta.Padding = new Padding(64, 0, 0, 0);
            buttonComprasConsulta.Size = new Size(212, 46);
            buttonComprasConsulta.TabIndex = 2;
            buttonComprasConsulta.Text = "Consultar compra";
            buttonComprasConsulta.TextAlign = ContentAlignment.MiddleLeft;
            buttonComprasConsulta.UseVisualStyleBackColor = true;
            buttonComprasConsulta.Click += ButtonComprasConsultaClick;
            // 
            // buttonCompraRegistro
            // 
            buttonCompraRegistro.Dock = DockStyle.Top;
            buttonCompraRegistro.FlatAppearance.BorderSize = 0;
            buttonCompraRegistro.FlatStyle = FlatStyle.Flat;
            buttonCompraRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCompraRegistro.ForeColor = Color.Gainsboro;
            buttonCompraRegistro.Location = new Point(0, 0);
            buttonCompraRegistro.Margin = new Padding(4, 3, 4, 3);
            buttonCompraRegistro.Name = "buttonCompraRegistro";
            buttonCompraRegistro.Padding = new Padding(64, 0, 0, 0);
            buttonCompraRegistro.Size = new Size(212, 46);
            buttonCompraRegistro.TabIndex = 0;
            buttonCompraRegistro.Text = "Registrar compra";
            buttonCompraRegistro.TextAlign = ContentAlignment.MiddleLeft;
            buttonCompraRegistro.UseVisualStyleBackColor = true;
            buttonCompraRegistro.Click += ButtonCompraRegistroClick;
            // 
            // buttonCompras
            // 
            buttonCompras.Dock = DockStyle.Top;
            buttonCompras.FlatAppearance.BorderSize = 0;
            buttonCompras.FlatStyle = FlatStyle.Flat;
            buttonCompras.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCompras.ForeColor = Color.WhiteSmoke;
            buttonCompras.Image = Papelera_Judy.Properties.Resources.compras;
            buttonCompras.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCompras.Location = new Point(0, 266);
            buttonCompras.Margin = new Padding(4, 3, 4, 3);
            buttonCompras.Name = "buttonCompras";
            buttonCompras.Padding = new Padding(6, 0, 0, 0);
            buttonCompras.Size = new Size(212, 52);
            buttonCompras.TabIndex = 3;
            buttonCompras.Text = "  Compras";
            buttonCompras.TextAlign = ContentAlignment.MiddleLeft;
            buttonCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCompras.UseVisualStyleBackColor = true;
            buttonCompras.Click += ButtonComprasClick;
            // 
            // panelVentasSubmenu
            // 
            panelVentasSubmenu.BackColor = Color.FromArgb(21, 45, 53);
            panelVentasSubmenu.Controls.Add(buttonVentaConsulta);
            panelVentasSubmenu.Controls.Add(buttonVentaRegistro);
            panelVentasSubmenu.Dock = DockStyle.Top;
            panelVentasSubmenu.Location = new Point(0, 167);
            panelVentasSubmenu.Margin = new Padding(4, 3, 4, 3);
            panelVentasSubmenu.Name = "panelVentasSubmenu";
            panelVentasSubmenu.Size = new Size(212, 99);
            panelVentasSubmenu.TabIndex = 2;
            // 
            // buttonVentaConsulta
            // 
            buttonVentaConsulta.Dock = DockStyle.Top;
            buttonVentaConsulta.FlatAppearance.BorderSize = 0;
            buttonVentaConsulta.FlatStyle = FlatStyle.Flat;
            buttonVentaConsulta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVentaConsulta.ForeColor = Color.Gainsboro;
            buttonVentaConsulta.Location = new Point(0, 46);
            buttonVentaConsulta.Margin = new Padding(4, 3, 4, 3);
            buttonVentaConsulta.Name = "buttonVentaConsulta";
            buttonVentaConsulta.Padding = new Padding(64, 0, 0, 0);
            buttonVentaConsulta.Size = new Size(212, 46);
            buttonVentaConsulta.TabIndex = 2;
            buttonVentaConsulta.Text = "Consultar venta";
            buttonVentaConsulta.TextAlign = ContentAlignment.MiddleLeft;
            buttonVentaConsulta.UseVisualStyleBackColor = true;
            buttonVentaConsulta.Click += ButtonVentaConsultaClick;
            // 
            // buttonVentaRegistro
            // 
            buttonVentaRegistro.Dock = DockStyle.Top;
            buttonVentaRegistro.FlatAppearance.BorderSize = 0;
            buttonVentaRegistro.FlatStyle = FlatStyle.Flat;
            buttonVentaRegistro.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVentaRegistro.ForeColor = Color.Gainsboro;
            buttonVentaRegistro.Location = new Point(0, 0);
            buttonVentaRegistro.Margin = new Padding(4, 3, 4, 3);
            buttonVentaRegistro.Name = "buttonVentaRegistro";
            buttonVentaRegistro.Padding = new Padding(64, 0, 0, 0);
            buttonVentaRegistro.Size = new Size(212, 46);
            buttonVentaRegistro.TabIndex = 0;
            buttonVentaRegistro.Text = "Registrar venta";
            buttonVentaRegistro.TextAlign = ContentAlignment.MiddleLeft;
            buttonVentaRegistro.UseVisualStyleBackColor = true;
            buttonVentaRegistro.Click += ButtonVentaRegistroClick;
            // 
            // buttonVentas
            // 
            buttonVentas.Dock = DockStyle.Top;
            buttonVentas.FlatAppearance.BorderSize = 0;
            buttonVentas.FlatStyle = FlatStyle.Flat;
            buttonVentas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVentas.ForeColor = Color.WhiteSmoke;
            buttonVentas.Image = Papelera_Judy.Properties.Resources.ventas;
            buttonVentas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonVentas.Location = new Point(0, 115);
            buttonVentas.Margin = new Padding(4, 3, 4, 3);
            buttonVentas.Name = "buttonVentas";
            buttonVentas.Padding = new Padding(6, 0, 0, 0);
            buttonVentas.Size = new Size(212, 52);
            buttonVentas.TabIndex = 1;
            buttonVentas.Text = "  Ventas";
            buttonVentas.TextAlign = ContentAlignment.MiddleLeft;
            buttonVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonVentas.UseVisualStyleBackColor = true;
            buttonVentas.Click += ButtonVentasClick;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 3, 4, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(212, 115);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Papelera_Judy.Properties.Resources.logo;
            pictureBox1.Location = new Point(14, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(52, 91, 99);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(229, 0);
            panelContenedor.Margin = new Padding(4, 3, 4, 3);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1246, 786);
            panelContenedor.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 786);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenuLateral);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1491, 825);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestor de Empresa Papelera Judy";
            panelMenuLateral.ResumeLayout(false);
            panelEmpleadosSubmenu.ResumeLayout(false);
            panelProveedoresSubmenu.ResumeLayout(false);
            panelProductosSubmenu.ResumeLayout(false);
            panelClienteSubmenu.ResumeLayout(false);
            panelComprasSubmenu.ResumeLayout(false);
            panelVentasSubmenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonComprasConsulta;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.Button buttonEmpleados;
		private System.Windows.Forms.Button buttonEmpleadoRegistro;
		private System.Windows.Forms.Button buttonEmpleadoModificacion;
		private System.Windows.Forms.Button buttonEmpleadoConsulta;
		private System.Windows.Forms.Panel panelEmpleadosSubmenu;
		private System.Windows.Forms.Button buttonIVA;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Button buttonProveedorRegistro;
		private System.Windows.Forms.Button buttonProveedorModificacion;
		private System.Windows.Forms.Button buttonProveedorConsulta;
		private System.Windows.Forms.Panel panelProveedoresSubmenu;
		private System.Windows.Forms.Button buttonClientes;
		private System.Windows.Forms.Button buttonClienteRegistro;
		private System.Windows.Forms.Button buttonClienteModificacion;
		private System.Windows.Forms.Button buttonClienteConsulta;
		private System.Windows.Forms.Panel panelClienteSubmenu;
		private System.Windows.Forms.Button buttonProductos;
		private System.Windows.Forms.Button buttonProductoRegistro;
		private System.Windows.Forms.Button buttonProductoModificacion;
		private System.Windows.Forms.Button buttonProductoConsulta;
		private System.Windows.Forms.Panel panelProductosSubmenu;
		private System.Windows.Forms.Button buttonProveedores;
		private System.Windows.Forms.Button buttonCompras;
		private System.Windows.Forms.Button buttonCompraRegistro;
		private System.Windows.Forms.Panel panelComprasSubmenu;
		private System.Windows.Forms.Button buttonVentaConsulta;
		private System.Windows.Forms.Button buttonVentaRegistro;
		private System.Windows.Forms.Button buttonVentas;
		private System.Windows.Forms.Panel panelVentasSubmenu;
		private System.Windows.Forms.Panel panelMenuLateral;
	}
}
