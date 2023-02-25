using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuisHernandez
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }



        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            RecorrerUnoAUno(1, 100);
        }
        private void RecorrerUnoAUno(int inicio, int final)
        {
            listBox1.Items.Add(inicio);
            if (inicio < final) 
            { 
                RecorrerUnoAUno(inicio + 1, final);
            }
            
        }

    }

}
