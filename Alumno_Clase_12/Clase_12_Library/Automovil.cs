using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library
{
    public class Automovil : Vehiculo
    {
        /// <summary>
        /// Recibe tres parametros e instancia un Objeto de tipo Automovil 
        /// </summary>
        /// <param name="marca">EMarca</param>
        /// <param name="patente"string</param>
        /// <param name="color">ConsoleColor</param>
        public Automovil(EMarca marca, string patente, ConsoleColor color):base(marca,patente, color)
        {
        }
        /// <summary>
        /// Los automoviles tienen 4 ruedas
        /// </summary>
        public override short CantidadRuedas
        {
            get
            {
                return 4;
            }
        }

        /// <summary>
        /// Sobrecarga del metodo Mostar 
        /// </summary>
        
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("AUTOMOVIL");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("RUEDAS : "+ this.CantidadRuedas);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
