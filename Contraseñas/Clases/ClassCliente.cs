using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contraseñas.Clases
{
    internal class ClassCliente
    {
        //Mostrar en una tabla
        public void Mostrar(DataGridView tablaCliente)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "select *  from cliente";
                tablaCliente.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConn.EstablecerConn());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCliente.DataSource = dt;
                objetoConn.CerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al mostrar"+ex.ToString());
            }
        }
        //mostrar en tabla por parametros
        public void MostrarEspecifico(DataGridView tablaCliente, string nombre)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "SELECT * FROM cliente WHERE nombre LIKE @nombre order by id";
                tablaCliente.DataSource = null;

                using (MySqlConnection connection = objetoConn.EstablecerConn())
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", "%"+nombre+"%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    tablaCliente.DataSource = dt;
                }

                objetoConn.CerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar: " + ex.ToString());
            }
        }

        //obtener en una lista
        public List<string> ObtenerNombres()
        {
            List<string> nombres = new List<string>();

            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "SELECT nombre FROM cliente";

                using (MySqlConnection conn = objetoConn.EstablecerConn())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nombres.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener nombres: " + ex.ToString());
            }

            return nombres;
        }
        public List<string> Obtenerid()
        {
            List<string> nombres = new List<string>();

            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "SELECT id FROM cliente";

                using (MySqlConnection conn = objetoConn.EstablecerConn())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nombres.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener nombres: " + ex.ToString());
            }

            return nombres;
        }
        // Insertar Clientes
        public void InsertarCliente(string nombre, string correo, string direccion, string telefono)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                using (MySqlConnection conn = objetoConn.EstablecerConn())
                {
                    var sql = "INSERT INTO cliente(nombre, correo, direccion, telefono) VALUES(@nombre, @correo, @direccion, @telefono)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se Registro correctamente.");
                    }
                }
                objetoConn.CerrarConn();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la alta de datos.");
            }
        }
        //modificar
        public void ModificarCliente(int id, string nuevoNombre, string nuevoCorreo, string nuevaDireccion, string nuevoTelefono)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "UPDATE cliente SET nombre = @nuevoNombre, correo = @nuevoCorreo, direccion = @nuevaDireccion, telefono = @nuevoTelefono WHERE id = @id";

                using (MySqlConnection connection = objetoConn.EstablecerConn())
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Usar parámetros para evitar la inyección SQL
                    cmd.Parameters.AddWithValue("@nuevoNombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("@nuevoCorreo", nuevoCorreo);
                    cmd.Parameters.AddWithValue("@nuevaDireccion", nuevaDireccion);
                    cmd.Parameters.AddWithValue("@nuevoTelefono", nuevoTelefono);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente modificado exitosamente");
                        objetoConn.CerrarConn();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente con el ID especificado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar cliente: " + ex.ToString());
            }
        }
        //Eliminar
        public void EliminarCliente(int id)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "DELETE FROM cliente WHERE id = @id";

                using (MySqlConnection connection = objetoConn.EstablecerConn())
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Usar parámetros para evitar la inyección SQL
                    cmd.Parameters.AddWithValue("@id",id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente eliminado exitosamente");
                        objetoConn.CerrarConn();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente con el ID especificado");
                        objetoConn.CerrarConn();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.ToString());
            }
        }
    }
}
