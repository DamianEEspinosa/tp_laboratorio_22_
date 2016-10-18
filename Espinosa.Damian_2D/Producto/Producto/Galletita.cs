using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
        
    public class Galletita:Producto
    {
        protected float _peso;
        protected static bool DeConsumo;


        #region constructores
       
        static Galletita()
        {
            DeConsumo = true;
        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso)
            : base(codigoBarra, marca, precio)
        {
            this._peso = peso;
        }

        #endregion


        #region Metodo


        /// <summary>
        /// Retorna un string de un obj galletita
        /// </summary>
        /// <returns>string</returns>
        private string MostarGalletita(Galletita g)
        { 
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("MARCA: " + g.Marca());
           sb.AppendLine("CODIGO DE BARRAS: " + g._codigoBarra);
           sb.AppendLine("PRECIO: " + g.Precio());
           sb.AppendLine("PESO: " + _peso);
           return sb.ToString();
        }

        /// <summary>
        /// Hace publico los datos de MostarGalletita
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostarGalletita(this);
        }

        /// <summary>
        /// Retorna Costo
        /// </summary>
        public override float CalcularCostodeProduccion
        {
            get
            {
              return Precio() * (float)0.33;
            }
        }

        /// <summary>
        /// Devuelve la cadena "Comestible"
        /// </summary>
        /// <returns></returns>
        public override string Consumir()
        {
            return "Comestible";
        }

        #endregion

    }
}
