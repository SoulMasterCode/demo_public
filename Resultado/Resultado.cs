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

namespace Resultado
{
    public partial class Resultado : Form
    {
      

        public Resultado()
        {
            InitializeComponent();
        }

        public void getResultado1(Int32 suma)
        {
            lblResultado1.Text = Convert.ToString(suma);
        }

        public void getResultado2(Int32 resta)
        {
            lblResultado2.Text = Convert.ToString(resta);
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal.Principal objP = new Principal.Principal();
            this.Hide();
            objP.Show();
        }
    }
}
