using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // <summary>
        /// dibuja el Form, inicializa combo de operaciones
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
        }


        /// <summary>
        /// Evento encargado de Limpiar los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNumero1.Clear();
            textNumero2.Clear();
            lblResultado.Text = "";
        }

        /// <summary>
        /// Evento encargado de Mostrar la leyenda de error si no se ingresa un caracter valido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void textNumero1_TextChanged(object sender, EventArgs e)
        {
            double num1 = 0;
            if (!double.TryParse(textNumero1.Text, out num1))
            {
                lblResultado.Text = "Error. Ingrese un valor numérico.";
            }
        }

        /// <summary>
        /// Evento encargado de Mostrar la leyenda de error si no se ingresa un caracter valido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void textNumero2_TextChanged(object sender, EventArgs e)
        {
            double num2 = 0;
            string o = cmbOperacion.Text;

            if (!double.TryParse(textNumero2.Text, out num2))
            {
                lblResultado.Text = "Error. Ingrese un valor numérico.";
            }           
            else if ((num2 == 0) && (o == "/"))
            {
                lblResultado.Text = "Error. division por cero";
            }
        }



        /// <summary>
        /// Evento encargado de realizar el calculo a traves de la funcion operar de la clase calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string selectedOperador = cmbOperacion.Text;
            string selectedNumber1 = textNumero1.Text;
            string selectedNumer2 = textNumero2.Text;
            double resultado;


            Numero numero1 = new Numero(selectedNumber1);
            Numero numero2 = new Numero(selectedNumer2);

            resultado = Calculadora.operar(numero1, numero2, selectedOperador);

            this.lblResultado.Text = resultado.ToString();


        }
  }
}
