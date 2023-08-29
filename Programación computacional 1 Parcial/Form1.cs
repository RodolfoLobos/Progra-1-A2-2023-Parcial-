using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programación_computacional_1_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            String[,] Area =  {
      {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectáreas" },
         };
            InitializeComponent();
        }

        private void btnConvertirArea_Click(object sender, EventArgs e)
        {
            int DE, A, conversor;
            double ctd, r;

            DE = cboDeArea.SelectedIndex;
            A = cboAarea.SelectedIndex;
            conversor = cboAarea.SelectedIndex;

            ctd = double.Parse(txtCantidadArea.Text);
            //Pie Cuadrado, Vara Cuadrada, Yarda Cuadrada, Metro Cuadrado, Tareas, Manzana, Hectáreas, 
            double[][] Areas = {
                new double[] { 10.7639, 0.698896, 0.836127, 1 , 628.8, 6474.9702758, 10000},
            };

            r = Areas[cboArea.SelectedIndex][DE] / Areas[cboArea.SelectedIndex][A] * ctd;
            lblRespuestaArea.Text = "Respuesta: " + Math.Round(r, 6);
        }
    }
}
