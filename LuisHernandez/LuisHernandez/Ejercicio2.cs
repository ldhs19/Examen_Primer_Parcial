using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuisHernandez
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void CalcularDescuentoButton_Click(object sender, EventArgs e)
        {
            decimal producto2, producto3;
            decimal totaldescuento;
            decimal descuento;
            decimal producto1;
            decimal total;
            

            producto1 = Convert.ToDecimal(ProductoUnoTextBox);
            producto2 = Convert.ToDecimal(ProductoDosTextBox);
            producto3 = Convert.ToDecimal(ProductoTresTextBox);

            total = producto1 + producto2 + producto3;


            descuento = total * 0.15m;
            totaldescuento = total - descuento;

            MessageBox.Show("descuento;" + totaldescuento + " " + "Monto Neto;" + total);




        }
    }
}
