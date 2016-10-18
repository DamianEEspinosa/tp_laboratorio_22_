using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    
    
    public class Harina:Producto
    {
        protected ETipoHarina _tipo;
        protected static bool DeConsumo;

        public enum ETipoHarina
        {
            CuatroCeros,
            Integral
        }

        #region constructores
       
        static Harina()
        {
            DeConsumo = false;
        }

        public Harina(int codigoBarra, float precio, EMarcaProducto marca, ETipoHarina tipo)
            : base(codigoBarra, marca, precio)
        {
            this._tipo = tipo;
        }

        #endregion


        #region Metodo

        /// <summary>
        /// Retorna un string de un obj Harina
        /// </summary>
        /// <returns>string</returns>
        private string MostarHarina()
        { 
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("MARCA: " + base.Marca());
           sb.AppendLine("CODIGO DE BARRAS: " + base._codigoBarra);
           sb.AppendLine("PRECIO: " + base.Precio());
           sb.AppendLine("TIPO: " + _tipo);
           return sb.ToString();
        }

        /// <summary>
        /// Hace publico los datos de MostarHarina
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostarHarina();
        }

        /// <summary>
        /// Retorna Costo
        /// </summary>
        public override float CalcularCostodeProduccion
        {
            get
            {
              return Precio() * (float)0.60;
            }
        }
        #endregion

    }
}
