using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Calculadora
    {

        /// <summary>
        /// Recibe dos Objetos Numero y un string operador
        /// </summary>
        /// <param name="numero1">Primer numero para la operacion</param>
        /// <param name="numero2">segundo numero para la operacion</param>
        /// <param name="operador">string de operador</param>
        /// <returns>Devuelve el valor de la operacion solicitada de los numeros pasados por parametros</returns>
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            operador = Calculadora.validarOperador(operador);
            double resultado = 0;
            switch (operador)
            {

                case "+":
                    resultado = numero1.getNumero() + numero2.getNumero();
                    break;
                case "-":
                    resultado = numero1.getNumero() - numero2.getNumero();
                    break;
                case "*":
                    resultado = numero1.getNumero() * numero2.getNumero();
                    break;
                case "/":
                    resultado = numero1.getNumero() / numero2.getNumero();
                    break;
            }
            return resultado;
        }


        /// <summary>
        /// Recibe un string las operaciones "+,-,*,/"
        /// Si no corresponde retorna un "+"
        /// </summary>
        /// <param name="operador">String que se recibe para validar el signo de operacion</param>
        /// <returns>En caso de que el string sea valido retorna ese string, caso contarrio retorna +</returns>
        public static string validarOperador(string operador)
        {
            if (operador != "+" && operador != "-" && operador != "*" && operador != "/")
                return "+";
            return operador;
        }
    }
}
