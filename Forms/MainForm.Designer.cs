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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.buttonIVA = new System.Windows.Forms.Button();
            this.panelEmpleadosSubmenu = new System.Windows.Forms.Panel();
            this.buttonEmpleadoConsulta = new System.Windows.Forms.Button();
            this.buttonEmpleadoModificacion = new System.Windows.Forms.Button();
            this.buttonEmpleadoRegistro = new System.Windows.Forms.Button();
            this.buttonEmpleados = new System.Windows.Forms.Button();
            this.panelProveedoresSubmenu = new System.Windows.Forms.Panel();
            this.buttonProveedorConsulta = new System.Windows.Forms.Button();
            this.buttonProveedorModificacion = new System.Windows.Forms.Button();
            this.buttonProveedorRegistro = new System.Windows.Forms.Button();
            this.buttonProveedores = new System.Windows.Forms.Button();
            this.panelProductosSubmenu = new System.Windows.Forms.Panel();
            this.buttonProductoConsulta = new System.Windows.Forms.Button();
            this.buttonProductoModificacion = new System.Windows.Forms.Button();
            this.buttonProductoRegistro = new System.Windows.Forms.Button();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.panelClienteSubmenu = new System.Windows.Forms.Panel();
            this.buttonClienteConsulta = new System.Windows.Forms.Button();
            this.buttonClienteModificacion = new System.Windows.Forms.Button();
            this.buttonClienteRegistro = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.panelComprasSubmenu = new System.Windows.Forms.Panel();
            this.buttonComprasConsulta = new System.Windows.Forms.Button();
            this.buttonCompraRegistro = new System.Windows.Forms.Button();
            this.buttonCompras = new System.Windows.Forms.Button();
            this.panelVentasSubmenu = new System.Windows.Forms.Panel();
            this.buttonVentaConsulta = new System.Windows.Forms.Button();
            this.buttonVentaRegistro = new System.Windows.Forms.Button();
            this.buttonVentas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenuLateral.SuspendLayout();
            this.panelEmpleadosSubmenu.SuspendLayout();
            this.panelProveedoresSubmenu.SuspendLayout();
            this.panelProductosSubmenu.SuspendLayout();
            this.panelClienteSubmenu.SuspendLayout();
            this.panelComprasSubmenu.SuspendLayout();
            this.panelVentasSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.panelMenuLateral.Controls.Add(this.buttonIVA);
            this.panelMenuLateral.Controls.Add(this.panelEmpleadosSubmenu);
            this.panelMenuLateral.Controls.Add(this.buttonEmpleados);
            this.panelMenuLateral.Controls.Add(this.panelProveedoresSubmenu);
            this.panelMenuLateral.Controls.Add(this.buttonProveedores);
            this.panelMenuLateral.Controls.Add(this.panelProductosSubmenu);
            this.panelMenuLateral.Controls.Add(this.buttonProductos);
            this.panelMenuLateral.Controls.Add(this.panelClienteSubmenu);
            this.panelMenuLateral.Controls.Add(this.buttonClientes);
            this.panelMenuLateral.Controls.Add(this.panelComprasSubmenu);
            this.panelMenuLateral.Controls.Add(this.buttonCompras);
            this.panelMenuLateral.Controls.Add(this.panelVentasSubmenu);
            this.panelMenuLateral.Controls.Add(this.buttonVentas);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(196, 681);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // buttonIVA
            // 
            this.buttonIVA.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIVA.FlatAppearance.BorderSize = 0;
            this.buttonIVA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIVA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonIVA.Image = ((System.Drawing.Image)(resources.GetObject("buttonIVA.Image")));
            this.buttonIVA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIVA.Location = new System.Drawing.Point(0, 1036);
            this.buttonIVA.Name = "buttonIVA";
            this.buttonIVA.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonIVA.Size = new System.Drawing.Size(179, 45);
            this.buttonIVA.TabIndex = 15;
            this.buttonIVA.Text = "  IVA";
            this.buttonIVA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIVA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonIVA.UseVisualStyleBackColor = true;
            this.buttonIVA.Click += new System.EventHandler(this.ButtonIVAClick);
            // 
            // panelEmpleadosSubmenu
            // 
            this.panelEmpleadosSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.panelEmpleadosSubmenu.Controls.Add(this.buttonEmpleadoConsulta);
            this.panelEmpleadosSubmenu.Controls.Add(this.buttonEmpleadoModificacion);
            this.panelEmpleadosSubmenu.Controls.Add(this.buttonEmpleadoRegistro);
            this.panelEmpleadosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmpleadosSubmenu.Location = new System.Drawing.Point(0, 912);
            this.panelEmpleadosSubmenu.Name = "panelEmpleadosSubmenu";
            this.panelEmpleadosSubmenu.Size = new System.Drawing.Size(179, 124);
            this.panelEmpleadosSubmenu.TabIndex = 14;
            // 
            // buttonEmpleadoConsulta
            // 
            this.buttonEmpleadoConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmpleadoConsulta.FlatAppearance.BorderSize = 0;
            this.buttonEmpleadoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleadoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleadoConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmpleadoConsulta.Location = new System.Drawing.Point(0, 80);
            this.buttonEmpleadoConsulta.Name = "buttonEmpleadoConsulta";
            this.buttonEmpleadoConsulta.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonEmpleadoConsulta.Size = new System.Drawing.Size(179, 40);
            this.buttonEmpleadoConsulta.TabIndex = 2;
            this.buttonEmpleadoConsulta.Text = "Consultar empleado";
            this.buttonEmpleadoConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpleadoConsulta.UseVisualStyleBackColor = true;
            this.buttonEmpleadoConsulta.Click += new System.EventHandler(this.ButtonEmpleadoConsultaClick);
            // 
            // buttonEmpleadoModificacion
            // 
            this.buttonEmpleadoModificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmpleadoModificacion.FlatAppearance.BorderSize = 0;
            this.buttonEmpleadoModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleadoModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleadoModificacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmpleadoModificacion.Location = new System.Drawing.Point(0, 40);
            this.buttonEmpleadoModificacion.Name = "buttonEmpleadoModificacion";
            this.buttonEmpleadoModificacion.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonEmpleadoModificacion.Size = new System.Drawing.Size(179, 40);
            this.buttonEmpleadoModificacion.TabIndex = 1;
            this.buttonEmpleadoModificacion.Text = "Modificar empleado";
            this.buttonEmpleadoModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpleadoModificacion.UseVisualStyleBackColor = true;
            this.buttonEmpleadoModificacion.Click += new System.EventHandler(this.ButtonEmpleadoModificacionClick);
            // 
            // buttonEmpleadoRegistro
            // 
            this.buttonEmpleadoRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmpleadoRegistro.FlatAppearance.BorderSize = 0;
            this.buttonEmpleadoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleadoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleadoRegistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmpleadoRegistro.Location = new System.Drawing.Point(0, 0);
            this.buttonEmpleadoRegistro.Name = "buttonEmpleadoRegistro";
            this.buttonEmpleadoRegistro.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonEmpleadoRegistro.Size = new System.Drawing.Size(179, 40);
            this.buttonEmpleadoRegistro.TabIndex = 0;
            this.buttonEmpleadoRegistro.Text = "Registrar empleado";
            this.buttonEmpleadoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpleadoRegistro.UseVisualStyleBackColor = true;
            this.buttonEmpleadoRegistro.Click += new System.EventHandler(this.ButtonEmpleadoRegistroClick);
            // 
            // buttonEmpleados
            // 
            this.buttonEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmpleados.FlatAppearance.BorderSize = 0;
            this.buttonEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmpleados.Image")));
            this.buttonEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpleados.Location = new System.Drawing.Point(0, 867);
            this.buttonEmpleados.Name = "buttonEmpleados";
            this.buttonEmpleados.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonEmpleados.Size = new System.Drawing.Size(179, 45);
            this.buttonEmpleados.TabIndex = 13;
            this.buttonEmpleados.Text = "  Empleados";
            this.buttonEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmpleados.UseVisualStyleBackColor = true;
            this.buttonEmpleados.Click += new System.EventHandler(this.ButtonEmpleadosClick);
            // 
            // panelProveedoresSubmenu
            // 
            this.panelProveedoresSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.panelProveedoresSubmenu.Controls.Add(this.buttonProveedorConsulta);
            this.panelProveedoresSubmenu.Controls.Add(this.buttonProveedorModificacion);
            this.panelProveedoresSubmenu.Controls.Add(this.buttonProveedorRegistro);
            this.panelProveedoresSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProveedoresSubmenu.Location = new System.Drawing.Point(0, 743);
            this.panelProveedoresSubmenu.Name = "panelProveedoresSubmenu";
            this.panelProveedoresSubmenu.Size = new System.Drawing.Size(179, 124);
            this.panelProveedoresSubmenu.TabIndex = 12;
            // 
            // buttonProveedorConsulta
            // 
            this.buttonProveedorConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProveedorConsulta.FlatAppearance.BorderSize = 0;
            this.buttonProveedorConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProveedorConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProveedorConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProveedorConsulta.Location = new System.Drawing.Point(0, 80);
            this.buttonProveedorConsulta.Name = "buttonProveedorConsulta";
            this.buttonProveedorConsulta.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonProveedorConsulta.Size = new System.Drawing.Size(179, 40);
            this.buttonProveedorConsulta.TabIndex = 2;
            this.buttonProveedorConsulta.Text = "Consultar proveedor";
            this.buttonProveedorConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProveedorConsulta.UseVisualStyleBackColor = true;
            this.buttonProveedorConsulta.Click += new System.EventHandler(this.ButtonProveedorConsultaClick);
            // 
            // buttonProveedorModificacion
            // 
            this.buttonProveedorModificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProveedorModificacion.FlatAppearance.BorderSize = 0;
            this.buttonProveedorModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProveedorModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProveedorModificacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProveedorModificacion.Location = new System.Drawing.Point(0, 40);
            this.buttonProveedorModificacion.Name = "buttonProveedorModificacion";
            this.buttonProveedorModificacion.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonProveedorModificacion.Size = new System.Drawing.Size(179, 40);
            this.buttonProveedorModificacion.TabIndex = 1;
            this.buttonProveedorModificacion.Text = "Modificar proveedor";
            this.buttonProveedorModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProveedorModificacion.UseVisualStyleBackColor = true;
            this.buttonProveedorModificacion.Click += new System.EventHandler(this.ButtonProveedorModificacionClick);
            // 
            // buttonProveedorRegistro
            // 
            this.buttonProveedorRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProveedorRegistro.FlatAppearance.BorderSize = 0;
            this.buttonProveedorRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProveedorRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProveedorRegistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProveedorRegistro.Location = new System.Drawing.Point(0, 0);
            this.buttonProveedorRegistro.Name = "buttonProveedorRegistro";
            this.buttonProveedorRegistro.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonProveedorRegistro.Size = new System.Drawing.Size(179, 40);
            this.buttonProveedorRegistro.TabIndex = 0;
            this.buttonProveedorRegistro.Text = "Registrar proveedor";
            this.buttonProveedorRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProveedorRegistro.UseVisualStyleBackColor = true;
            this.buttonProveedorRegistro.Click += new System.EventHandler(this.ButtonProveedorRegistroClick);
            // 
            // buttonProveedores
            // 
            this.buttonProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProveedores.FlatAppearance.BorderSize = 0;
            this.buttonProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProveedores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonProveedores.Image = ((System.Drawing.Image)(resources.GetObject("buttonProveedores.Image")));
            this.buttonProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProveedores.Location = new System.Drawing.Point(0, 698);
            this.buttonProveedores.Name = "buttonProveedores";
            this.buttonProveedores.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonProveedores.Size = new System.Drawing.Size(179, 45);
            this.buttonProveedores.TabIndex = 11;
            this.buttonProveedores.Text = "  Proveedores";
            this.buttonProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProveedores.UseVisualStyleBackColor = true;
            this.buttonProveedores.Click += new System.EventHandler(this.ButtonProveedoresClick);
            // 
            // panelProductosSubmenu
            // 
            this.panelProductosSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.panelProductosSubmenu.Controls.Add(this.buttonProductoConsulta);
            this.panelProductosSubmenu.Controls.Add(this.buttonProductoModificacion);
            this.panelProductosSubmenu.Controls.Add(this.buttonProductoRegistro);
            this.panelProductosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductosSubmenu.Location = new System.Drawing.Point(0, 574);
            this.panelProductosSubmenu.Name = "panelProductosSubmenu";
            this.panelProductosSubmenu.Size = new System.Drawing.Size(179, 124);
            this.panelProductosSubmenu.TabIndex = 10;
            // 
            // buttonProductoConsulta
            // 
            this.buttonProductoConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProductoConsulta.FlatAppearance.BorderSize = 0;
            this.buttonProductoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductoConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProductoConsulta.Location = new System.Drawing.Point(0, 80);
            this.buttonProductoConsulta.Name = "buttonProductoConsulta";
            this.buttonProductoConsulta.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonProductoConsulta.Size = new System.Drawing.Size(179, 40);
            this.buttonProductoConsulta.TabIndex = 2;
            this.buttonProductoConsulta.Text = "Consultar producto";
            this.buttonProductoConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductoConsulta.UseVisualStyleBackColor = true;
            this.buttonProductoConsulta.Click += new System.EventHandler(this.ButtonProductoConsultaClick);
            // 
            // buttonProductoModificacion
            // 
            this.buttonProductoModificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProductoModificacion.FlatAppearance.BorderSize = 0;
            this.buttonProductoModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductoModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductoModificacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProductoModificacion.Location = new System.Drawing.Point(0, 40);
            this.buttonProductoModificacion.Name = "buttonProductoModificacion";
            this.buttonProductoModificacion.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonProductoModificacion.Size = new System.Drawing.Size(179, 40);
            this.buttonProductoModificacion.TabIndex = 1;
            this.buttonProductoModificacion.Text = "Modificar producto";
            this.buttonProductoModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductoModificacion.UseVisualStyleBackColor = true;
            this.buttonProductoModificacion.Click += new System.EventHandler(this.ButtonProductoModificacionClick);
            // 
            // buttonProductoRegistro
            // 
            this.buttonProductoRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProductoRegistro.FlatAppearance.BorderSize = 0;
            this.buttonProductoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductoRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductoRegistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProductoRegistro.Location = new System.Drawing.Point(0, 0);
            this.buttonProductoRegistro.Name = "buttonProductoRegistro";
            this.buttonProductoRegistro.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonProductoRegistro.Size = new System.Drawing.Size(179, 40);
            this.buttonProductoRegistro.TabIndex = 0;
            this.buttonProductoRegistro.Text = "Registrar producto";
            this.buttonProductoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductoRegistro.UseVisualStyleBackColor = true;
            this.buttonProductoRegistro.Click += new System.EventHandler(this.ButtonProductoRegistroClick);
            // 
            // buttonProductos
            // 
            this.buttonProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProductos.FlatAppearance.BorderSize = 0;
            this.buttonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonProductos.Image = ((System.Drawing.Image)(resources.GetObject("buttonProductos.Image")));
            this.buttonProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductos.Location = new System.Drawing.Point(0, 529);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonProductos.Size = new System.Drawing.Size(179, 45);
            this.buttonProductos.TabIndex = 9;
            this.buttonProductos.Text = "  Productos";
            this.buttonProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProductos.UseVisualStyleBackColor = true;
            this.buttonProductos.Click += new System.EventHandler(this.ButtonProductosClick);
            // 
            // panelClienteSubmenu
            // 
            this.panelClienteSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.panelClienteSubmenu.Controls.Add(this.buttonClienteConsulta);
            this.panelClienteSubmenu.Controls.Add(this.buttonClienteModificacion);
            this.panelClienteSubmenu.Controls.Add(this.buttonClienteRegistro);
            this.panelClienteSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClienteSubmenu.Location = new System.Drawing.Point(0, 405);
            this.panelClienteSubmenu.Name = "panelClienteSubmenu";
            this.panelClienteSubmenu.Size = new System.Drawing.Size(179, 124);
            this.panelClienteSubmenu.TabIndex = 8;
            // 
            // buttonClienteConsulta
            // 
            this.buttonClienteConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClienteConsulta.FlatAppearance.BorderSize = 0;
            this.buttonClienteConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClienteConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClienteConsulta.Location = new System.Drawing.Point(0, 80);
            this.buttonClienteConsulta.Name = "buttonClienteConsulta";
            this.buttonClienteConsulta.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonClienteConsulta.Size = new System.Drawing.Size(179, 40);
            this.buttonClienteConsulta.TabIndex = 2;
            this.buttonClienteConsulta.Text = "Consultar cliente";
            this.buttonClienteConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClienteConsulta.UseVisualStyleBackColor = true;
            this.buttonClienteConsulta.Click += new System.EventHandler(this.ButtonClienteConsultaClick);
            // 
            // buttonClienteModificacion
            // 
            this.buttonClienteModificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClienteModificacion.FlatAppearance.BorderSize = 0;
            this.buttonClienteModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClienteModificacion.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClienteModificacion.Location = new System.Drawing.Point(0, 40);
            this.buttonClienteModificacion.Name = "buttonClienteModificacion";
            this.buttonClienteModificacion.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonClienteModificacion.Size = new System.Drawing.Size(179, 40);
            this.buttonClienteModificacion.TabIndex = 1;
            this.buttonClienteModificacion.Text = "Modificar cliente";
            this.buttonClienteModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClienteModificacion.UseVisualStyleBackColor = true;
            this.buttonClienteModificacion.Click += new System.EventHandler(this.ButtonClienteModificacionClick);
            // 
            // buttonClienteRegistro
            // 
            this.buttonClienteRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClienteRegistro.FlatAppearance.BorderSize = 0;
            this.buttonClienteRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClienteRegistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClienteRegistro.Location = new System.Drawing.Point(0, 0);
            this.buttonClienteRegistro.Name = "buttonClienteRegistro";
            this.buttonClienteRegistro.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonClienteRegistro.Size = new System.Drawing.Size(179, 40);
            this.buttonClienteRegistro.TabIndex = 0;
            this.buttonClienteRegistro.Text = "Registrar cliente";
            this.buttonClienteRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClienteRegistro.UseVisualStyleBackColor = true;
            this.buttonClienteRegistro.Click += new System.EventHandler(this.ButtonClienteRegistroClick);
            // 
            // buttonClientes
            // 
            this.buttonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClientes.Image = ((System.Drawing.Image)(resources.GetObject("buttonClientes.Image")));
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.Location = new System.Drawing.Point(0, 360);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonClientes.Size = new System.Drawing.Size(179, 45);
            this.buttonClientes.TabIndex = 7;
            this.buttonClientes.Text = "  Clientes";
            this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.ButtonClientesClick);
            // 
            // panelComprasSubmenu
            // 
            this.panelComprasSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.panelComprasSubmenu.Controls.Add(this.buttonComprasConsulta);
            this.panelComprasSubmenu.Controls.Add(this.buttonCompraRegistro);
            this.panelComprasSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelComprasSubmenu.Location = new System.Drawing.Point(0, 276);
            this.panelComprasSubmenu.Name = "panelComprasSubmenu";
            this.panelComprasSubmenu.Size = new System.Drawing.Size(179, 84);
            this.panelComprasSubmenu.TabIndex = 4;
            // 
            // buttonComprasConsulta
            // 
            this.buttonComprasConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonComprasConsulta.FlatAppearance.BorderSize = 0;
            this.buttonComprasConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComprasConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComprasConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonComprasConsulta.Location = new System.Drawing.Point(0, 40);
            this.buttonComprasConsulta.Name = "buttonComprasConsulta";
            this.buttonComprasConsulta.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonComprasConsulta.Size = new System.Drawing.Size(179, 40);
            this.buttonComprasConsulta.TabIndex = 2;
            this.buttonComprasConsulta.Text = "Consultar compra";
            this.buttonComprasConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComprasConsulta.UseVisualStyleBackColor = true;
            this.buttonComprasConsulta.Click += new System.EventHandler(this.ButtonComprasConsultaClick);
            // 
            // buttonCompraRegistro
            // 
            this.buttonCompraRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCompraRegistro.FlatAppearance.BorderSize = 0;
            this.buttonCompraRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompraRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompraRegistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCompraRegistro.Location = new System.Drawing.Point(0, 0);
            this.buttonCompraRegistro.Name = "buttonCompraRegistro";
            this.buttonCompraRegistro.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonCompraRegistro.Size = new System.Drawing.Size(179, 40);
            this.buttonCompraRegistro.TabIndex = 0;
            this.buttonCompraRegistro.Text = "Registrar compra";
            this.buttonCompraRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompraRegistro.UseVisualStyleBackColor = true;
            this.buttonCompraRegistro.Click += new System.EventHandler(this.ButtonCompraRegistroClick);
            // 
            // buttonCompras
            // 
            this.buttonCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCompras.FlatAppearance.BorderSize = 0;
            this.buttonCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompras.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCompras.Image = ((System.Drawing.Image)(resources.GetObject("buttonCompras.Image")));
            this.buttonCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompras.Location = new System.Drawing.Point(0, 231);
            this.buttonCompras.Name = "buttonCompras";
            this.buttonCompras.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonCompras.Size = new System.Drawing.Size(179, 45);
            this.buttonCompras.TabIndex = 3;
            this.buttonCompras.Text = "  Compras";
            this.buttonCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCompras.UseVisualStyleBackColor = true;
            this.buttonCompras.Click += new System.EventHandler(this.ButtonComprasClick);
            // 
            // panelVentasSubmenu
            // 
            this.panelVentasSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.panelVentasSubmenu.Controls.Add(this.buttonVentaConsulta);
            this.panelVentasSubmenu.Controls.Add(this.buttonVentaRegistro);
            this.panelVentasSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentasSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelVentasSubmenu.Name = "panelVentasSubmenu";
            this.panelVentasSubmenu.Size = new System.Drawing.Size(179, 86);
            this.panelVentasSubmenu.TabIndex = 2;
            // 
            // buttonVentaConsulta
            // 
            this.buttonVentaConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVentaConsulta.FlatAppearance.BorderSize = 0;
            this.buttonVentaConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentaConsulta.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonVentaConsulta.Location = new System.Drawing.Point(0, 40);
            this.buttonVentaConsulta.Name = "buttonVentaConsulta";
            this.buttonVentaConsulta.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonVentaConsulta.Size = new System.Drawing.Size(179, 40);
            this.buttonVentaConsulta.TabIndex = 2;
            this.buttonVentaConsulta.Text = "Consultar venta";
            this.buttonVentaConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVentaConsulta.UseVisualStyleBackColor = true;
            this.buttonVentaConsulta.Click += new System.EventHandler(this.ButtonVentaConsultaClick);
            // 
            // buttonVentaRegistro
            // 
            this.buttonVentaRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVentaRegistro.FlatAppearance.BorderSize = 0;
            this.buttonVentaRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentaRegistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonVentaRegistro.Location = new System.Drawing.Point(0, 0);
            this.buttonVentaRegistro.Name = "buttonVentaRegistro";
            this.buttonVentaRegistro.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.buttonVentaRegistro.Size = new System.Drawing.Size(179, 40);
            this.buttonVentaRegistro.TabIndex = 0;
            this.buttonVentaRegistro.Text = "Registrar venta";
            this.buttonVentaRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVentaRegistro.UseVisualStyleBackColor = true;
            this.buttonVentaRegistro.Click += new System.EventHandler(this.ButtonVentaRegistroClick);
            // 
            // buttonVentas
            // 
            this.buttonVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVentas.FlatAppearance.BorderSize = 0;
            this.buttonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonVentas.Image = ((System.Drawing.Image)(resources.GetObject("buttonVentas.Image")));
            this.buttonVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVentas.Location = new System.Drawing.Point(0, 100);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonVentas.Size = new System.Drawing.Size(179, 45);
            this.buttonVentas.TabIndex = 1;
            this.buttonVentas.Text = "  Ventas";
            this.buttonVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.Click += new System.EventHandler(this.ButtonVentasClick);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(179, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(91)))), ((int)(((byte)(99)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(196, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1068, 681);
            this.panelContenedor.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gestor de Empresa Papelera Judy";
            this.panelMenuLateral.ResumeLayout(false);
            this.panelEmpleadosSubmenu.ResumeLayout(false);
            this.panelProveedoresSubmenu.ResumeLayout(false);
            this.panelProductosSubmenu.ResumeLayout(false);
            this.panelClienteSubmenu.ResumeLayout(false);
            this.panelComprasSubmenu.ResumeLayout(false);
            this.panelVentasSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
