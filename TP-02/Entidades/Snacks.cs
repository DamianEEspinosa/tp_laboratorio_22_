using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Entidades_2017
namespace Entidades
{
    public class Snacks:Producto
    {
        public Snacks(EMarca marca, string codigoDeBarras, ConsoleColor color)
            : base(marca, codigoDeBarras, color)
        {
        }
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();

        }
    }
}
