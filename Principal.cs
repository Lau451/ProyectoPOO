using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPOO
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //admin
            if (Login.tipo == "A0001")

            {
                btnalmacen.Enabled = true;
                btnventas.Enabled = true;
                btncompras.Enabled = true;

                lblCargo.Text = "Administrador";
            }

            //Cliente
            else if (Login.tipo == "A0002")

            {
                btnalmacen.Enabled = false;
                btnventas.Enabled = false;
                btncompras.Enabled = true;

                lblCargo.Text = "Cliente";
            }
            lblnombre.Text = Login.usuario_nombre;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
