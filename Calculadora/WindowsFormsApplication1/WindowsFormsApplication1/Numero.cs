using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Numero
    {
        private double _numero;

        #region Constructores

        /// <summary>
        /// Instancia un objeto Numero por Default 
        /// </summary>
        public Numero()
        {
            this._numero = 0.0;
        }

        /// <summary>
        /// Recibe un Double e instancia un Objeto Numero 
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this._numero = numero;
        }


        /// <summary>
        /// Recibe un string e instancia un Objeto Numero validando desde setNumero.
        /// </summary>
        /// <param name="numero">String con el numero recibido</param>
        public Numero(string numero)
        {
            this.setNumero(numero);
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Retorna un double perteneciente al objeto Numero
        /// </summary>
        public double getNumero()
        {
            return this._numero;
        }

        /// <summary>
        /// Recibe un string referente al objeto numero
        /// </summary>
        /// <param name="numero">string para validar</param>
        private void setNumero(string numero)
        {
            this._numero = Numero.validarNumero(numero);
        }
        #endregion

        #region Metodo

        /// <summary>
        /// Recibe un string y lo asigna al atributo numero del objeto
        /// </summary>
        /// <param name="numeroString">string con numero a asignar a atrib numero</param>
        private static double validarNumero(string numeroString)
        {
            double resultado;
            if (!double.TryParse(numeroString, out resultado))
            {
                resultado = 0;
            }
            return resultado;
        }
        #endregion
    }
}
