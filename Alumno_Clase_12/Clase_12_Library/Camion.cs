using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_12_Library;
using System.Drawing;

namespace Clase_12_Library
{
    public class Camion:Vehiculo
    {
        /// <summary>
        /// Recibe tres parametros e instancia un Objeto de tipo Camion 
        /// </summary>
        /// <param name="marca">EMarca</param>
        /// <param name="patente"string</param>
        /// <param name="color">ConsoleColor</param>
        public Camion(EMarca marca, string patente, ConsoleColor color):base(marca,patente, color)
        {
        }
        /// <summary>
        /// Los camiones tienen 8 ruedas
        /// </summary>
       public override short CantidadRuedas
        {
            get
            {
                return 8;
            }
        }


       /// <summary>
       /// Sobrecarga del metodo Mostar 
       /// </summary>         
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMION");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("RUEDAS :" +this.CantidadRuedas);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
