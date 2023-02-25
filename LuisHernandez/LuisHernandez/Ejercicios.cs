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
    public partial class Ejercicios : Form
    {
        public Ejercicios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1 eje1Form= new Ejercicio1();
            eje1Form.MdiParent= this;   
            eje1Form.Show();    


        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2 eje2Form = new Ejercicio2();
            eje2Form.MdiParent = this;
            eje2Form.Show();

        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio3 eje3Form = new Ejercicio3();
            eje3Form.MdiParent = this;
            eje3Form.Show();
        }
    }
}
