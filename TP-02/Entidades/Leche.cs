using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Leche : Producto
    {
     
        ETipo _tipo = ETipo.Entera;

        public enum ETipo { Entera, Descremada }

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigoDeBarras"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color):base(marca, codigoDeBarras, color)
        {
            this._tipo = ETipo.Entera;
        }

        public Leche(EMarca marca, string codigoDeBarras, ConsoleColor color, ETipo tipo):base(marca, codigoDeBarras, color)            
        {
            this._tipo = tipo;
        }

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this._tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
           }
        }
    }

