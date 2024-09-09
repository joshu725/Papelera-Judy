using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PapeleraJudy
{
    class PostgreSQL
    {
        // Cambiar los datos dependiendo de tu base de datos en PostgreSQL
        NpgsqlConnection conexion = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = 2123a; Database = papelera-judy");

        public void Conectar()
        {
            conexion.Open();
        }

        bool numeros(string texto)
        {
            foreach (char letra in texto)
            {
                if (letra < '0' || letra > '9')
                {
                    return false;
                }
            }

            return true;
        }

        public int UltimoID(string t)
        {
            int numero = 0;
            string query = "select last_value from " + t + "_id" + t + "_seq";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            numero = Int32.Parse(tabla.Rows[0][0].ToString());
            if (numero == 1)
            {
                query = "select count(*) from " + t;
                comando = new NpgsqlCommand(query, conexion);
                datos = new NpgsqlDataAdapter(comando);
                tabla = new DataTable();
                datos.Fill(tabla);
                if (Int32.Parse(tabla.Rows[0][0].ToString()) == 0)
                {
                    return 0;
                }
            }
            return numero;
        }



        public DataTable Consultar(string t)
        {
            string query = "select * from " + t + " order by id" + t + " asc";
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        //-----------Consultas primarias-----------

        public DataTable ConsultarCliente(string t)
        {
            string query;

            if (numeros(t) == false)
            {
                query = "select * from cliente" +
                            " where nombre like '%" + t + "%'" +
                            " or direccion like '%" + t + "%'" +
                            " or telefono like '%" + t + "%'" +
                            " or correo like '%" + t + "%' order by idcliente asc";
            }
            else
            {
                query = "select * from cliente" +
                            " where idcliente = " + t +
                            " or nombre like '%" + t + "%'" +
                            " or direccion like '%" + t + "%'" +
                            " or telefono like '%" + t + "%'" +
                            " or correo like '%" + t + "%' order by idcliente asc";
            }

            NpgsqlCommand comando;

            if (t != "")
            {
                comando = new NpgsqlCommand(query, conexion);
            }
            else
            {
                comando = new NpgsqlCommand("select * from cliente order by idcliente asc", conexion);
            }

            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public DataTable ConsultarProducto(string t)
        {
            string query;

            if (numeros(t) == false)
            {
                query = "select * from producto" +
                            " where nombre like '%" + t + "%'" +
                            " or descripcion like '%" + t + "%' order by idproducto asc";
            }
            else
            {
                query = "select * from producto" +
                            " where idproducto = " + t +
                            " or descripcion like '%" + t + "%'" +
                            " or precio = " + t +
                            " or existencia = " + t + " order by idproducto asc";
            }

            NpgsqlCommand comando;

            if (t != "")
            {
                comando = new NpgsqlCommand(query, conexion);
            }
            else
            {
                comando = new NpgsqlCommand("select * from producto order by idproducto asc", conexion);
            }

            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public DataTable ConsultarProveedor(string t)
        {
            string query;

            if (numeros(t) == false)
            {
                query = "select * from proveedor" +
                            " where nombre like '%" + t + "%'" +
                            " or nombreempresa like '%" + t + "%'" + 
                            " or telefono like '%" + t + "%'" +
                            " or correo like '%" + t + "%' order by idproveedor asc";
            }
            else
            {
                query = "select * from proveedor" +
                            " where idproveedor = " + t +
                            " or telefono like '%" + t + "%' order by idproveedor asc";
            }

            NpgsqlCommand comando;

            if (t != "")
            {
                comando = new NpgsqlCommand(query, conexion);
            }
            else
            {
                comando = new NpgsqlCommand("select * from proveedor order by idproveedor asc", conexion);
            }

            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        public DataTable ConsultarEmpleado(string t)
        {
            string query;

            if (numeros(t) == false)
            {
                query = "select * from empleado" +
                            " where nombre like '%" + t + "%'" +
                            " or cargo like '%" + t + "%'" +
                            " or direccion like '%" + t + "%'" +
                            " or telefono like '%" + t + "%'" +
                            " or sexo like '%" + t + "%' order by idempleado asc";
            }
            else
            {
                query = "select * from empleado" +
                            " where idempleado = " + t +
                            " or telefono like '%" + t + "%'" +
                            " or status = " + t + " order by idempleado asc";
            }

            NpgsqlCommand comando;

            if (t != "")
            {
                comando = new NpgsqlCommand(query, conexion);
            }
            else
            {
                comando = new NpgsqlCommand("select * from empleado order by idempleado asc", conexion);
            }

            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);
            return tabla;
        }

        //--------------------------------------------

        //-------------Registros primarios-------------

        public void RegistrarCliente(string nombre, string direccion, string telefono, string correo)
        {
            string query = "insert into cliente (nombre, direccion, telefono, correo) values ('" +
                nombre + "','" +
                direccion + "','" +
                telefono + "','" +
                correo + "')";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void RegistrarProducto(string nombre, string descripcion, string precio, string existencia)
        {
            string query = "insert into producto (nombre, descripcion, precio, existencia) values ('" +
                nombre + "','" +
                descripcion + "'," +
                precio + "," +
                existencia + ")";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void RegistrarProveedor(string nombre, string nombreempresa, string telefono, string correo)
        {
            string query = "insert into proveedor (nombre, nombreempresa, telefono, correo)values ('" +
                nombre + "','" +
                nombreempresa + "','" +
                telefono + "','" +
                correo + "')";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void RegistrarEmpleado(string nombre, string cargo, string direccion, string telefono, string sexo, string fechanacimiento, string status)
        {
            string query = "insert into empleado (nombre, cargo, direccion, telefono, sexo, fechanacimiento, status) values ('" +
                nombre + "','" +
                cargo + "','" +
                direccion + "','" +
                telefono + "','" +
                sexo + "','" +
                fechanacimiento + "'," +
                status + ")";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void RegistrarIVA(string porcentaje, string fecha)
        {
            string query = "insert into iva (porcentaje, fechaaplicacion) values (" +
                porcentaje + ",'" +
                fecha + "')";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        //--------------------------------------------

        //----------Modificaciones primarios----------

        public DataTable ConsultarID(string t, string id)
        {
            string query = "select * from " + t + " where id" + t + " = " + id;
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        public void ModificarCliente(string id, string nombre, string direccion, string telefono, string correo)
        {
            string query = "update cliente set nombre = '" + nombre +
                            "', direccion = '" + direccion +
                            "', telefono = '" + telefono +
                            "', correo = '" + correo +
                            "' where idcliente = " + id;

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void ModificarProducto(string id, string nombre, string descripcion, string precio, string existencia)
        {
            string query = "update producto set nombre = '" + nombre +
                            "', descripcion = '" + descripcion +
                            "', precio = " + precio +
                            ", existencia = " + existencia +
                            " where idproducto = " + id;

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void ModificarProveedor(string id, string nombre, string nombreempresa, string telefono, string correo)
        {
            string query = "update proveedor set nombre = '" + nombre +
                            "', nombreempresa = '" + nombreempresa +
                            "', telefono = '" + telefono +
                            "', correo = '" + correo +
                            "' where idproveedor = " + id;

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void ModificarEmpleado(string id, string nombre, string cargo, string direccion, string telefono, string sexo, string fechanacimiento, string status)
        {
            string query = "update empleado set nombre = '" + nombre +
                            "', cargo = '" + cargo +
                            "', direccion = '" + direccion +
                            "', telefono = '" + telefono +
                            "', sexo = '" + sexo +
                            "', fechanacimiento = '" + fechanacimiento +
                            "', status = " + status +
                            " where idempleado = " + id;

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        //--------------------------------------------

        //----------Registro de venta----------

        public void RegistrarVenta(string idcliente, string idempleado, string fecha)
        {
            string query = "insert into venta (idcliente, idempleado, fecha) values (" +
                                               idcliente + "," +
                                               idempleado + ",'" +
                                               fecha + "')";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void RegistrarDetalleVenta(string idventa, string idproducto, string cantidad, string precio)
        {
            string query = "insert into detalleventas (idventa, idproducto, cantidad, precio) values (" +
                                               idventa + "," +
                                               idproducto + "," +
                                               cantidad + "," +
                                               precio + ")";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void RestarCantidadProducto(string id, string cantidad)
        {
            string query = "update producto set existencia = existencia - " + cantidad + " where idproducto = " + id;

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        //----------Registro de compra----------

        public void RegistrarCompra(string idproveedor, string idempleado, string fecha)
        {
            string query = "insert into compra (idproveedor, idempleado, fecha) values (" +
                                               idproveedor + "," +
                                               idempleado + ",'" +
                                               fecha + "')";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void RegistrarDetalleCompra(string idcompra, string idproducto, string cantidad, string preciocompra)
        {
            string query = "insert into detallecompras (idcompra, idproducto, cantidad, preciocompra) values (" +
                                               idcompra + "," +
                                               idproducto + "," +
                                               cantidad + "," +
                                               preciocompra + ")";

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        public void SumarCantidadProducto(string id, string cantidad)
        {
            string query = "update producto set existencia = existencia + " + cantidad + " where idproducto = " + id;

            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            comando.ExecuteNonQuery();
        }

        //--------------------------------------------
        //--------------------------------------------
        //--------------------------------------------

        //Consultar venta

        public DataTable ConsultarDetalleVentas(string id)
        {
            string query = "select * from detalleventas where idventa = " + id;
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }

        //Consultar compra

        public DataTable ConsultarDetalleCompras(string id)
        {
            string query = "select * from detallecompras where idcompra = " + id;
            NpgsqlCommand comando = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter datos = new NpgsqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            datos.Fill(tabla);

            return tabla;
        }


    }
}
