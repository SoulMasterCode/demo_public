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

namespace OtroProceso
{
    public partial class LblOtroProceso : Form
    {
        Int16 dato1, dato2, dato3;
        Int32 resta;

        public LblOtroProceso()
        {
            InitializeComponent();
        }

        public void getDatosResta(Int16 a, Int16 b, Int16 c)
        {
            dato1 = a;
            dato2 = b;
            dato3 = c;

            lblDato1.Text = Convert.ToString(a);
            lblDato2.Text = Convert.ToString(b);
            lblDato3.Text = Convert.ToString(c);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal.Principal principal = new Principal.Principal();
            this.Hide();
            resta = dato1 - dato2 - dato3;
            principal.getOp2(resta);
            principal.Show();
        }
    }
}
