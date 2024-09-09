using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PapeleraJudy
{

	public partial class MainForm : Form
	{
		Form formVentasRegistro = new VentasRegistro();
		Form formVentasConsulta = new VentasConsulta();
		Form formComprasRegistro = new ComprasRegistro();
		Form formComprasConsulta = new ComprasConsulta();
		Form formClientesRegistro = new ClientesRegistro();
		Form formClientesModificacion = new ClientesModificacion();
		Form formEmpleadosRegistro = new EmpleadosRegistro();
		Form formEmpleadosModificacion = new EmpleadosModificacion();
		Form formProductosRegistro = new ProductosRegistro();
		Form formProductosModificacion = new ProductosModificacion();
		Form formProveedorRegistro = new ProveedorRegistro();
		Form formProveedorModificacion = new ProveedorModificacion();
		Form formIVA = new IVA();

		int formConsulta = 0;

		public MainForm()
		{
			
			InitializeComponent();
			personalizarDiseno();

		}
		
		private void personalizarDiseno(){
			panelVentasSubmenu.Visible = false;
			panelComprasSubmenu.Visible = false;
			panelClienteSubmenu.Visible = false;
			panelProductosSubmenu.Visible = false;
			panelProveedoresSubmenu.Visible = false;
			panelEmpleadosSubmenu.Visible = false;
		}
		
		private void ocultarSubmenu(){
			if (panelVentasSubmenu.Visible == true){
				panelVentasSubmenu.Visible = false;
			}
			if (panelComprasSubmenu.Visible == true){
				panelComprasSubmenu.Visible = false;
			}
			if (panelClienteSubmenu.Visible == true){
				panelClienteSubmenu.Visible = false;
			}
			if (panelProductosSubmenu.Visible == true){
				panelProductosSubmenu.Visible = false;
			}
			if (panelProveedoresSubmenu.Visible == true){
				panelProveedoresSubmenu.Visible = false;
			}
			if (panelEmpleadosSubmenu.Visible == true){
				panelEmpleadosSubmenu.Visible = false;
			}
		}
		
		private void mostrarSubmenu(Panel subMenu){
			if (subMenu.Visible == false){
				ocultarSubmenu();
				subMenu.Visible = true;
			}else{
				subMenu.Visible = false;
			}
		}
		
		//--------Ventas---------
		
		void ButtonVentasClick(object sender, EventArgs e)
		{
			mostrarSubmenu(panelVentasSubmenu);
		}
		
		void ButtonVentaRegistroClick(object sender, EventArgs e)
		{
			abrirFormulario(formVentasRegistro);

			ocultarSubmenu();
		}
		
		void ButtonVentaConsultaClick(object sender, EventArgs e)
		{
			abrirFormulario(formVentasConsulta);

			ocultarSubmenu();
		}
		
		//-----------Compras-----------
		
		void ButtonComprasClick(object sender, EventArgs e)
		{
			mostrarSubmenu(panelComprasSubmenu);
		}
		
		void ButtonCompraRegistroClick(object sender, EventArgs e)
		{
			abrirFormulario(formComprasRegistro);

			ocultarSubmenu();
		}
			
		void ButtonComprasConsultaClick(object sender, EventArgs e)
		{
			abrirFormulario(formComprasConsulta);

			ocultarSubmenu();
		}
		
		//--------Clientes-----------
		
		void ButtonClientesClick(object sender, EventArgs e)
		{
			mostrarSubmenu(panelClienteSubmenu);
		}
		
		void ButtonClienteRegistroClick(object sender, EventArgs e)
		{
			abrirFormulario(formClientesRegistro);

			ocultarSubmenu();
		}
		
		void ButtonClienteModificacionClick(object sender, EventArgs e)
		{
			abrirFormulario(formClientesModificacion);

			ocultarSubmenu();
		}
		
		void ButtonClienteConsultaClick(object sender, EventArgs e)
		{
			formConsulta = 1;
			abrirFormulario(new ClientesConsulta());

			ocultarSubmenu();
		}
		
		//------------Productos-----------
		
		void ButtonProductosClick(object sender, EventArgs e)
		{
			mostrarSubmenu(panelProductosSubmenu);
		}
		
		
		void ButtonProductoRegistroClick(object sender, EventArgs e)
		{
			abrirFormulario(formProductosRegistro);

			ocultarSubmenu();
		}
		
		void ButtonProductoModificacionClick(object sender, EventArgs e)
		{
			abrirFormulario(formProductosModificacion);

			ocultarSubmenu();
		}
		
		void ButtonProductoConsultaClick(object sender, EventArgs e)
		{
			formConsulta = 1;
			abrirFormulario(new ProductosConsulta());

			ocultarSubmenu();
		}
		
		//---------------Proveedores----------------
		
		
		
		void ButtonProveedoresClick(object sender, EventArgs e)
		{
			mostrarSubmenu(panelProveedoresSubmenu);
		}
		
		
		void ButtonProveedorRegistroClick(object sender, EventArgs e)
		{
			abrirFormulario(formProveedorRegistro);

			ocultarSubmenu();
		}
		
		void ButtonProveedorModificacionClick(object sender, EventArgs e)
		{
			abrirFormulario(formProveedorModificacion);

			ocultarSubmenu();
		}
		
		void ButtonProveedorConsultaClick(object sender, EventArgs e)
		{
			formConsulta = 1;
			abrirFormulario(new ProveedorConsulta());

			ocultarSubmenu();
		}
		
		//---------Empleados----------
		
		void ButtonEmpleadosClick(object sender, EventArgs e)
		{
			mostrarSubmenu(panelEmpleadosSubmenu);
		}
		
		
		
		void ButtonEmpleadoRegistroClick(object sender, EventArgs e)
		{
			abrirFormulario(formEmpleadosRegistro);

			ocultarSubmenu();
		}
		
		void ButtonEmpleadoModificacionClick(object sender, EventArgs e)
		{
			abrirFormulario(formEmpleadosModificacion);

			ocultarSubmenu();
		}
		
		void ButtonEmpleadoConsultaClick(object sender, EventArgs e)
		{
			formConsulta = 1;
			abrirFormulario(new EmpleadosConsulta());

			ocultarSubmenu();
		}
		
		//------------IVA-------------
		
		void ButtonIVAClick(object sender, EventArgs e)
		{
			abrirFormulario(formIVA);

			ocultarSubmenu();
		}

		//--------------------------------------------------------------------------------------------------------------------------------
		
		private Form formularioActivo = null;

		private void abrirFormulario(Form formularioHijo){
			if (formularioActivo != null)
			{
				formularioActivo.Close();
			}

			if(formConsulta == 1)
            {
				formularioActivo = formularioHijo;
				formConsulta = 0;
			}

			panelContenedor.Controls.Clear();
			formularioHijo.TopLevel = false;
			formularioHijo.FormBorderStyle = FormBorderStyle.None;
			formularioHijo.Dock = DockStyle.Fill;
			panelContenedor.Controls.Add(formularioHijo);
			panelContenedor.Tag = formularioHijo;
			formularioHijo.Show();

		}

    }
}
