using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public enum EMarcaProducto{ 
                        Favorita,
                        Pitusa, 
                        Diversion,
                        Naranju,
                        Swift                           
                       }
    
    public enum ETipoProducto { 
                        Galletita, 
                        Gaseosa, 
                        Jugo,
                        Harina, 
                        Todos 
     }

    public abstract class Producto
    {
        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        #region constructores

        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }

        #endregion


        #region Propiedades

        /// <summary>
        /// Retorna atributo _marca
        /// </summary>
        public EMarcaProducto Marca()
        {
            return this._marca;
        }


        /// <summary>
        /// Retorna atributo _precio
        /// </summary>
        public float Precio()
        {
            return this._precio;
        }

        /// <summary>
        /// Retorna CalcularCostodeProduccion 
        /// </summary>
        public abstract float CalcularCostodeProduccion
        {
            get;            
        } 
        #endregion

        #region Metodo

        /// <summary>
        /// Retorna los datos del producto
        /// </summary>
        /// <param name="p"></param>
        /// <returns>string</returns>
        private static string MostrarProducto(Producto p) 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MARCA:" + p.Marca());
            sb.AppendLine("CODIGO DE BARRA:" + p._codigoBarra);
            sb.AppendLine("PRECIO:" + p.Precio());

            return sb.ToString();

        }


        /// <summary>
        /// Verifica si dos productos son iguales
        /// </summary>
        /// <param name="prodUno"></param>
        /// <param name="prodDos"></param>
        /// <returns>true si son iguales, false si no</returns>
        public static bool operator ==(Producto ProdUno, Producto ProdDos)
        {
            if ((ProdUno.Marca() == ProdDos.Marca()) && (ProdUno.Precio() == ProdDos.Precio()) && (ProdUno._codigoBarra == ProdDos._codigoBarra))
                return true;

            return false;
        }

        /// <summary>
        /// Verifica si dos productos NO son iguales
        /// </summary>
        /// <param name="prodUno"></param>
        /// <param name="prodDos"></param>
        /// <returns>true si son iguales, false si no</returns>
        public static bool operator !=(Producto ProdUno, Producto ProdDos) 
        {
            return !(ProdUno==ProdDos);
        }


        /// <summary>
        /// Compara un producto con su Marca
        /// </summary>
        /// <param name="prodUno"></param>
        /// <param name="marca"></param>
        /// <returns>true si son iguales, false si no</returns>
        public static bool operator ==(Producto ProdUno, EMarcaProducto marca)
        {
            if (ProdUno.Marca() == marca)
                return true;
            return false;
        }

        /// <summary>
        /// Compara un producto con su Marca si NO son iguales
        /// </summary>
        /// <param name="prodUno"></param>
        /// <param name="marca"></param>
        /// <returns>true si son iguales, false si no</returns>
        public static bool operator !=(Producto ProdUno, EMarcaProducto marca)
        {
            return !(ProdUno == marca);
        }


        /// <summary>
        /// Retorna el codigo del producto pasado por parametro
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static explicit operator int(Producto Prod)
        {         
            return Prod._codigoBarra;
        }

        /// <summary>
        /// Retorna el string del producto
        /// </summary>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static implicit operator string(Producto Prod)
        {

            return Producto.MostrarProducto(Prod);
        }
        

        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }

        /// <summary>
        /// Sobreescribe el metodo padre, evalua si los objetos son del mismo tipo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) { return ReferenceEquals(this, obj); }

        /// <summary>
        /// Invoca al metodo de la clase padre
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion 
    }
}
