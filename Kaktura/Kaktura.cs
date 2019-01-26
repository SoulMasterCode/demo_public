using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaktura
{
    public partial class Kaktura : Form
    {

        Int16 uno, dos, tres;

        public Kaktura()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Principal.Principal objP = new Principal.Principal();
            
            this.Hide();

            //MAndar datos a principal
            objP.RecibeDatos(uno,dos,tres);

            objP.Show();
        }

        private void TxtDato1_TextChanged(object sender, EventArgs e)
        {
            uno = Convert.ToInt16(TxtDato1.Text);
        }

        private void TxtDato2_TextChanged(object sender, EventArgs e)
        {
            dos = Convert.ToInt16(TxtDato2.Text);
        }

        private void TxtDato3_TextChanged(object sender, EventArgs e)
        {
            tres = Convert.ToInt16(TxtDato3.Text);
        }



    }
}
