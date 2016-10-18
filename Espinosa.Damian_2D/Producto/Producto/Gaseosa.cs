using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
   
    public class Gaseosa:Producto
    {
        protected float _litros;
        protected static bool DeConsumo;
                
        #region constructores
       
        static Gaseosa()
        {
            DeConsumo = true;
        }

        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros)
            : base(codigoBarra, marca, precio)
        {
            this._litros= litros;
        }

        public Gaseosa(Producto p, float _litros):base((int)p,p.Marca(),p.Precio())
        {            
            this._litros = _litros;
        }           
       #endregion


        #region Metodo

        /// <summary>
        /// Retorna un string de un obj Gaseosa
        /// </summary>
        /// <returns>string</returns>
        private string MostarGaseosa()
        { 
           StringBuilder sb = new StringBuilder();
           
           sb.AppendLine("MARCA: "+base.Marca());
           sb.AppendLine("CODIGO DE BARRAS: "+ base._codigoBarra);
           sb.AppendLine("PRECIO: "+base.Precio());
           sb.AppendLine("LITROS: " + this._litros);
           return sb.ToString();
        }

        /// <summary>
        /// Hace publico los datos de MostarGaseosa
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostarGaseosa();
        }

        /// <summary>
        /// Retorna Costo
        /// </summary>
        public override float CalcularCostodeProduccion
        {
            get
            {
              return Precio() * (float)0.42;
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
