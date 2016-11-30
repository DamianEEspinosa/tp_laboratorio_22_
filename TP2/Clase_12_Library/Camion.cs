using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library
{
    public class Camion : Vehiculo //Se modifico para que camion herede de vehiculo
    {
        public Camion(Vehiculo.EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
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

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAMION");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("RUEDAS : {0}", this.CantidadRuedas); 
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString(); 
        }
    }
}
