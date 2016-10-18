using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
   
    
    public class Jugo:Producto
    {
        protected ESaborJugo _sabor;
        protected static bool DeConsumo;

        public enum ESaborJugo
        {
            Pasable,
            Asqueroso
        }

        #region constructores
       
        static Jugo()
        {
            DeConsumo = true;
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor)
            : base(codigoBarra, marca, precio)
        {
            this._sabor = sabor;
        }

        #endregion


        #region Metodo

        /// <summary>
        /// Retorna un string de un obj Jugo
        /// </summary>
        /// <returns>string</returns>
        private string MostarJugo()
        { 
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("MARCA: " + base.Marca());
           sb.AppendLine("CODIGO DE BARRAS: " + base._codigoBarra);
           sb.AppendLine("PRECIO: " + base.Precio());
           sb.AppendLine("SABOR: " + _sabor);
           return sb.ToString();
        }

        /// <summary>
        /// Hace publico los datos de MostarHarina
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostarJugo();
        }

        /// <summary>
        /// Retorna Costo
        /// </summary>
        public override float CalcularCostodeProduccion
        {
            get
            {
              return Precio() * (float)0.40;
            }
        }

        /// <summary>
        /// Devuelve la cadena "Bebible"
        /// </summary>
        /// <returns></returns>
        public override string Consumir()
        {
            return "Bebible";
        }

        #endregion

    }
}
