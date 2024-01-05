using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Contraseñas
{
    public partial class Form2 : Form
    { 

        private List<Clases.ClassCliente> clientes = new List<Clases.ClassCliente>();
        static Clases.ClassCliente objetoCliente = new Clases.ClassCliente();
        static Clases.ClassPass ObjetoPass = new Clases.ClassPass();
        static Clases.ClassProductos ObjetoProducto = new Clases.ClassProductos();
        List<string> listNombresClientes = objetoCliente.ObtenerNombres();
        List<string> listIDCliente = objetoCliente.Obtenerid();
        static int id_cliente = 0, id_contra=0;
        String NombreUser = "";
        //----------------------------------------------------------------------

        public Form2(String NombreUsuario)
        {
            InitializeComponent();
            NombreUser = NombreUsuario;
            lblHeader.Text = "Bienvenido " + NombreUser;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ObjetoPass.Mostrar(dgvPass);
            //ObjetoProducto.MostrarProd(dgvProductos);
            objetoCliente.Mostrar(dgvClientes);
            objetoCliente.Mostrar(dgvAgregrClientes);
            dgvPass.ClearSelection();
            dgvAgregrClientes.ClearSelection();
            dgvClientes.ClearSelection();
            if (dgvAgregrClientes.CurrentRow != null)
            {
                dgvClientes.CurrentRow.DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }
        private void MostrarSugerencias(List<string> sugerencias)
        {
        }

        private async Task ActualizarSugerenciasAsync()
        {
            
            string textoBusqueda = txtNombreClienteContra.Text.ToLower();
            var sugerenciasFiltradas = await Task.Run(() =>
                listNombresClientes.Where(s => s.ToLower().Contains(textoBusqueda)).ToList());

            await Task.Run(() => MostrarSugerencias(sugerenciasFiltradas));

            
        }

        private void ltbSugerencias_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            objetoCliente.MostrarEspecifico(dgvClientes, txtNombreClienteContra.Text);
            ObjetoPass.MostrarEspecifico(dgvPass,txtNombreClienteContra.Text);

        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            gpoAgregarCliente.Enabled = false;
            gpoAgregarCliente.Visible = false;
            txtNombreClienteContra.Enabled = true;
            txtNombreClienteContra.Visible = true;
            lblNombre.Enabled = true;
            lblNombre.Visible = true;
        }

        private void radSi_CheckedChanged(object sender, EventArgs e)
        {
            gpoAgregarCliente.Enabled = true;
            gpoAgregarCliente.Visible = true;
            txtNombreClienteContra.Enabled = false;
            txtNombreClienteContra.Visible = false;
            lblNombre.Enabled = false;
            lblNombre.Visible = false;
        }

        private void gpoAgregar_Enter(object sender, EventArgs e)
        {

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_contra != 0)
                {
                    ObjetoPass.ModificarContras(id_contra, int.Parse(txtID.Text), rtxtDescripcion.Text, txtUsuarioContra.Text, txtContra.Text);
                    ActualizarContras();
                    ActualizarClientes();
                }
                else
                {
                    MessageBox.Show("Seleccione una contraseña y/o cliente", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un cliente", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        private void dgvClientes_Click(object sender, EventArgs e)
        {
            int fila = dgvClientes.CurrentRow.Index;
            txtID.Text = dgvClientes.Rows[fila].Cells[0].Value.ToString();
            txtNombreClienteContra.Text = dgvClientes.Rows[fila].Cells[1].Value.ToString();
            dgvPass.ClearSelection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length>0)
            {
                if (txtContra.Text.Length>0)
                {
                    if (rtxtDescripcion.Text.Length>0)
                    {
                        ObjetoPass.InsertarPass(int.Parse(txtID.Text), rtxtDescripcion.Text, txtUsuarioContra.Text, txtContra.Text);
                        ActualizarContras();
                        LimpiarContras();
                    }
                    else
                    {
                        MessageBox.Show("debde de escribir una descripcion", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("debe de escribir una contraseña", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtClienteInsert.Text.Length > 0)
            {
                bool esNum = true;
                try
                {
                    if (txtTelefonoInsert.Text.Length==0)
                    {
                        esNum = true;
                    }
                    else
                    {
                        foreach (char Num in txtTelefonoInsert.Text)
                        {
                            if (!char.IsDigit(Num))
                            {
                                esNum = false;
                            }
                        }
                    }
                    if (esNum)
                    {
                        objetoCliente.InsertarCliente(txtClienteInsert.Text.ToUpper(), txtCorreoInsert.Text, txtDireccionInsert.Text, txtTelefonoInsert.Text);
                        ActualizarClientes();
                        ActualizarContras();
                        LimpiarClientes();
                    }
                    else
                    {
                        MessageBox.Show("El registro telefono solo debe de tener numeros","Warning!!!" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Registre todos los campos", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("es nesesario que llene el nombre del cliente","Warning!!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void txtClienteInsert_TextChanged(object sender, EventArgs e)
        {
            objetoCliente.MostrarEspecifico(dgvAgregrClientes, txtClienteInsert.Text);
        }

        private void dgvAgregrClientes_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvAgregrClientes.CurrentRow.Index;
                id_cliente = int.Parse(dgvAgregrClientes.Rows[fila].Cells[0].Value.ToString());
                txtClienteInsert.Text = dgvAgregrClientes.Rows[fila].Cells[1].Value.ToString();
                fila = dgvAgregrClientes.CurrentRow.Index;
                txtCorreoInsert.Text = dgvAgregrClientes.Rows[fila].Cells[2].Value.ToString();
                fila = dgvAgregrClientes.CurrentRow.Index;
                txtDireccionInsert.Text = dgvAgregrClientes.Rows[fila].Cells[3].Value.ToString();
                fila = dgvAgregrClientes.CurrentRow.Index;
                txtTelefonoInsert.Text = dgvAgregrClientes.Rows[fila].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                LimpiarClientes();
            }
        }

        private void btnLimpiarClientes_Click(object sender, EventArgs e)
        {
            LimpiarClientes();
        }

        private void btnModificarClientes_Click(object sender, EventArgs e)
        {
            if (id_cliente!=0)
            {
                objetoCliente.ModificarCliente(id_cliente, txtClienteInsert.Text, txtCorreoInsert.Text, txtDireccionInsert.Text, txtTelefonoInsert.Text);
                ActualizarClientes();
                ActualizarContras();
                LimpiarClientes();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un cliente","Warning!!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if(id_cliente!=0)
            {
                DialogResult respuesta = MessageBox.Show("El cliente se eliminara permanente mente.\n¿Esta seguro?", "Warning!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (respuesta == DialogResult.OK)
                {
                    objetoCliente.EliminarCliente(id_cliente);
                    ActualizarClientes();
                    ActualizarContras();
                    LimpiarClientes();
                }
            }
            else
            {
                MessageBox.Show("Seleccionar un cliente.","Warning!!!", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarContra_Click(object sender, EventArgs e)
        {
            LimpiarContras();
            id_contra = 0;
            dgvPass.ClearSelection();
            dgvClientes.ClearSelection();
        }
        public void LimpiarContras()
        {
            id_cliente = 0;
            txtID.Clear();
            txtUsuarioContra.Clear();
            txtNombreClienteContra.Clear();
            txtContra.Clear();
            rtxtDescripcion.Clear();
        }
        public void LimpiarClientes()
        {
            id_cliente = 0;
            txtClienteInsert.Clear();
            txtCorreoInsert.Clear();
            txtDireccionInsert.Clear();
            txtTelefonoInsert.Clear();
        }
        public void ActualizarContras()
        {
            ObjetoPass.Mostrar(dgvPass);
        }
        public void ActualizarClientes()
        {
            objetoCliente.Mostrar(dgvAgregrClientes);
        }

        private void dgvPass_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (id_contra!=0)
            {
                DialogResult respuesta = MessageBox.Show("La contraseña se eliminara permanente mente.\n¿Esta seguro?", "Warning!",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (respuesta == DialogResult.OK)
                {
                    ObjetoPass.EliminarContra(id_contra);
                    ActualizarContras();
                }
            }
            else
            {
                MessageBox.Show("Debe de Seleccionar un cliente", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbxAgregarProd_Enter(object sender, EventArgs e)
        {

        }

        private void cdrContra_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fecha = cdrContra.SelectionStart;
            string fechaString = fecha.ToShortDateString();
            MessageBox.Show(fechaString.ToString());
        }

        private void gpoAgregarUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dgvPass_Click(object sender, EventArgs e)
        {
            try
            {

                int fila = dgvPass.CurrentRow.Index;
                id_contra = int.Parse(dgvPass.Rows[fila].Cells[0].Value.ToString());
                txtContra.Text = dgvPass.Rows[fila].Cells[4].Value.ToString();
                txtUsuarioContra.Text = dgvPass.Rows[fila].Cells[3].Value.ToString();
                rtxtDescripcion.Text = dgvPass.Rows[fila].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                id_contra = 0;
            }
        }
    }
}
