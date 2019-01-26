using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Principal : Form
    {
        Int16 opcion;
        Int16 rec1, rec2, rec3;
        Int32 Result, Result2;
       
        public Principal()
        {
            InitializeComponent();
        }

        private void TxtOpcion_TextChanged(object sender, EventArgs e)
        {
            opcion = Convert.ToInt16(TxtOpcion.Text);
            
            switch (opcion){
                case 1:
                    {
                        //LLamar a la clase Kaktura
                        Kaktura.Kaktura objK = new Kaktura.Kaktura();
                        this.Hide();
                        objK.Show();
                        break;
                    }

                case 2:
                    {
                        Proceso.LblProceso objP = new Proceso.LblProceso();

                        this.Hide();
                        objP.getDatos(rec1, rec2, rec3);
                        objP.Show();
                        break;
                    }

                case 3:
                    {
                        OtroProceso.LblOtroProceso objOp = new OtroProceso.LblOtroProceso();
                        this.Hide();
                        objOp.getDatosResta(rec1, rec2, rec3);
                        objOp.Show();
                        break;
                    }

                case 4:
                    {
                        Resultado.Resultado objR = new Resultado.Resultado();
                        this.Hide();
                        objR.getResultado1(Result);
                        objR.getResultado1(Result2);
                        objR.Show();
                        break;
                    }

                default:
                    {
                        //Error
                        LblMensajeError.Text = "Opción valida";
                        break;
                    }
            }

        }

        
        //Metodo de usuario que va a recibir los datos de KAKTURA

        public void RecibeDatos(Int16 a, Int16 b, Int16 c)
        {
            rec1 = a;
            rec2 = b;
            rec3 = c;

            label2.Text = Convert.ToString(rec1);
            label3.Text = Convert.ToString(rec2);
            label4.Text = Convert.ToString(rec3);

            return;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblMensajeError_Click(object sender, EventArgs e)
        {

        }

        private void LblResultados_Click(object sender, EventArgs e)
        {

        }

        private void LblOtroProceso_Click(object sender, EventArgs e)
        {

        }

        private void LblProceso_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void LblKaktura_Click(object sender, EventArgs e)
        {

        }

        public void getOp1(Int32 suma)=>Result = suma;

        public void getOp2(Int32 resta)=>Result2 = resta;

        private void Principal_Load(object sender, EventArgs e)
        {
            //No hay nada
        }
    }
}
