using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_Mayor_de_5_2._0
{
    public partial class Form1 : Form
    {
        string Resultado1;
        private Identificar op = new Identificar();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            //___________________________________________________________________
            //Variables
            double n1;
            double n2;
            double n3;
            double n4;
            double n5;
            //___________________________________________________________________
            //Convertir Variables
            n1 = double.Parse(txtb1.Text);
            n2 = double.Parse(txtb2.Text);
            n3 = double.Parse(txtb3.Text);
            n4 = double.Parse(txtb4.Text);
            n5 = double.Parse(txtb5.Text);
            //__________________________________________________________________
            //Llamar funcion y retorna un variable
            Resultado1 = op.Identificar2(n1, n2, n3, n4, n5);
            //__________________________________________________________________
            //Mostrar Resustado en La etiqueta
            Resultado.Text = Resultado1;
            //__________________________________________________________________
            
        }
    }
}
