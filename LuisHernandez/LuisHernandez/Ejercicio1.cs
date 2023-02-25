using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuisHernandez
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void CalcularInteresButton_Click(object sender, EventArgs e)
        {



           double interesmensual = 200000 * 0.015 * 1;
           double interesanual = 200000 * 0.015 * 12;


            listBox1.Items.Add("El interes que genera mensual es; LPS."+" "+interesmensual);
            listBox1.Items.Add("El interes que genera al año es; LPS." + " " + interesanual);
            
            //string[] mes = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio,", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };


            // for (int  i = 1 ; i < 13   ; i ++)



            {
                   // listBox1.Items.Add();
                }

        

            


        }

    }
}
