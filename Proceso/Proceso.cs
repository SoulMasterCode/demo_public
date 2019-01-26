using Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proceso
{
    public partial class LblProceso : Form
    {
        Int16 dato1, dato2, dato3;
        Int32 suma;

        public LblProceso()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //No hay nada
        }

        private void LblProceso_Load(object sender, EventArgs e)
        {

            //No hay nada
        }

        public void getDatos(Int16 a, Int16 b, Int16 c)
        {
            dato1 = a;
            dato2 = b;
            dato3 = c;

            lblDato1.Text=Convert.ToString(a);
            lblDato2.Text = Convert.ToString(b);
            lblDato3.Text = Convert.ToString(c);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal.Principal objP = new Principal.Principal();
            this.Hide();
            suma = dato1 + dato2 + dato3;
            objP.getOp1(suma);
            objP.Show();
        }
    }
}
