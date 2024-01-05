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
    internal class ClassProductos
    {
        public void MostrarProd(DataGridView tablaPass)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "SELECT P.id as ID, P.nombre as Nombre, M.nombre as Marca, C.categoria as Categoria, P.modelo as Modelo, P.descripcipn as Descripcion FROM producto as P, marca as M, categoria_prod as C where P.id_marca = M.id and P.id_cat = C.id;\r\n";
                tablaPass.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConn.EstablecerConn());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPass.DataSource = dt;
                objetoConn.CerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al mostrar" + ex.ToString());
            }
        }
        public void MostrarMarca(DataGridView tablaPass)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "SELECT P.id as ID, P.nombre as Nombre, M.nombre as Marca, C.categoria as Categoria, P.modelo as Modelo, P.descripcipn as Descripcion FROM producto as P, marca as M, categoria_prod as C where P.id_marca = M.id and P.id_cat = C.id;\r\n";
                tablaPass.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConn.EstablecerConn());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPass.DataSource = dt;
                objetoConn.CerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al mostrar" + ex.ToString());
            }
        }
        public void MostrarCat(DataGridView tablaPass)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "SELECT P.id as ID, P.nombre as Nombre, M.nombre as Marca, C.categoria as Categoria, P.modelo as Modelo, P.descripcipn as Descripcion FROM producto as P, marca as M, categoria_prod as C where P.id_marca = M.id and P.id_cat = C.id;\r\n";
                tablaPass.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConn.EstablecerConn());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPass.DataSource = dt;
                objetoConn.CerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al mostrar" + ex.ToString());
            }
        }
        // Insertar
        public void InsertarProd(int id_Cliente, string descripcion, string pass)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                using (MySqlConnection conn = objetoConn.EstablecerConn())
                {
                    var sql = "INSERT INTO contra(id_cliente, descripcion, pass) VALUES(@id_cliente, @descripcion, @pass)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", id_Cliente);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@pass", pass);
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
        public void MostrarEspecificoProd(DataGridView tablaPass, string nombre)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "SELECT pw.id,c.nombre, pw.descripcion, pw.pass from contra as pw, cliente as c where pw.id_cliente = c.id and c.nombre like @nombre order by c.nombre";
                tablaPass.DataSource = null;

                using (MySqlConnection connection = objetoConn.EstablecerConn())
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    tablaPass.DataSource = dt;
                }

                objetoConn.CerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar: " + ex.ToString());
            }
        }

        //modificar
        public void ModificarProd(int id, int id_Cliente, string Desc, string pass)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "UPDATE contra SET id_cliente = @Nuevoid_cliente, descripcion = @NuevaDesc, pass = @NuevaPass WHERE id = @id";

                using (MySqlConnection connection = objetoConn.EstablecerConn())
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Usar parámetros para evitar la inyección SQL
                    cmd.Parameters.AddWithValue("@Nuevoid_cliente", id_Cliente);
                    cmd.Parameters.AddWithValue("@NuevaDesc", Desc);
                    cmd.Parameters.AddWithValue("@NuevaPass", pass);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos modificados exitosamente");
                        objetoConn.CerrarConn();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró contraseña con el ID especificado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar los datos: " + ex.ToString());
            }
        }
        //Eliminar
        public void EliminarProd(int id)
        {
            try
            {
                ClassConexion objetoConn = new Clases.ClassConexion();
                string query = "DELETE FROM contra WHERE id = @id";
                using (MySqlConnection connection = objetoConn.EstablecerConn())
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Usar parámetros para evitar la inyección SQL
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Contraseña eliminado exitosamente");
                        objetoConn.CerrarConn();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la contraseña con el ID especificado", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        objetoConn.CerrarConn();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: ", "Warning!!!" + ex.ToString());
            }
        }
    }
}
