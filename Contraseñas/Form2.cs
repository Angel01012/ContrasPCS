using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<string> sugerencias = new List<string>
        {
            "C#",
            "C++",
            "Java",
            "Python",
            "JavaScript",
            "HTML",
            "CSS",
            "SQL",
            // Agrega más sugerencias según tus necesidades
        };
        String NombreUser = "";
        public Form2(String NombreUsuario)
        {
            InitializeComponent();
            NombreUser = NombreUsuario;
            lblHeader.Text = "Bienvenido " + NombreUser;
            ltbSugerencias.Visible = false;
            gpoAgregarCliente.Visible = false;
            gpoAgregarCliente.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void MostrarSugerencias(List<string> sugerencias)
        {
            if (ltbSugerencias.InvokeRequired)
            {
                ltbSugerencias.Invoke(new Action(() => MostrarSugerencias(sugerencias)));
            }
            else
            {
                ltbSugerencias.Items.Clear();
                ltbSugerencias.Items.AddRange(sugerencias.ToArray());
            }
        }

        private async Task ActualizarSugerenciasAsync()
        {
            
            string textoBusqueda = txtIdCliente.Text.ToLower();
            var sugerenciasFiltradas = await Task.Run(() =>
                sugerencias.Where(s => s.ToLower().Contains(textoBusqueda)).ToList());

            await Task.Run(() => MostrarSugerencias(sugerenciasFiltradas));

            ltbSugerencias.Visible = sugerenciasFiltradas.Any();
            
        }

        private void ltbSugerencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbSugerencias.SelectedIndex != -1)
            {
                txtIdCliente.Text = ltbSugerencias.SelectedItem.ToString();
                ltbSugerencias.Visible = false;
            }
        }

        private async void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (sugerencias.Contains(txtIdCliente.Text))
            {
                ltbSugerencias.Visible = false;
                txtUsuario.Focus();
            }
            else
            {
                await ActualizarSugerenciasAsync();
            }
        }

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            gpoAgregarCliente.Enabled = false;
            gpoAgregarCliente.Visible = false;
            txtIdCliente.Enabled = true;
            txtIdCliente.Visible = true;
            lblNombre.Enabled = true;
            lblNombre.Visible = true;
        }

        private void radSi_CheckedChanged(object sender, EventArgs e)
        {
            gpoAgregarCliente.Enabled = true;
            gpoAgregarCliente.Visible = true;
            txtIdCliente.Enabled = false;
            txtIdCliente.Visible = false;
            lblNombre.Enabled = false;
            lblNombre.Visible = false;
        }
    }
}
