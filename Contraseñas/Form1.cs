using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contraseñas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: "+txtUsuario.Text + " \nContra: " + txtContra.Text);
            string usuario = txtUsuario.Text;
            Form Menu = new Form2(usuario);
            this.Hide();
            Menu.ShowDialog();

            // Una vez que Form2 se haya cerrado, mostrar Form1 nuevamente
            this.Show();
        }
    }
}
