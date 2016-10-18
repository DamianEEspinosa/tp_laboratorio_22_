using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class Estante
    {

        protected sbyte _capacidad;
        protected List<Producto> _productos;
        


        #region Constructores
        private Estante()
        {
            _productos = new List<Producto>();
        }


        public Estante(sbyte capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }
        
        #endregion

        /// <summary>
        /// Retrona total del valor por estante
        /// </summary>
        public float ValorEstanteTotal
        {
            get
            {
                return GetValorEstante();
            }
        }

        /// <summary>
        /// Retrona una lista de estante
        /// </summary>
        public List<Producto> GetProductos()
        {
            return _productos;
        }

        #region Metodo


        /// <summary>
        /// Retorna la informacion de la clase pasando un obj como parametro
        /// </summary>
        /// <param name=Estante></param>
        /// <returns></returns>
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CAPACIDAD: " + e._capacidad.ToString());
           
            foreach (Producto prod in e._productos)
            {
                if (prod is Harina)
                {
                    sb.AppendLine(prod.ToString());
                }
                else if (prod is Jugo)
                {
                    sb.AppendLine(prod.ToString());
                }
                else if (prod is Gaseosa)
                {
                    sb.AppendLine(prod.ToString());
                }
                else if (prod is Galletita)
                {
                    sb.AppendLine(prod.ToString());
                }
            }
            return sb.ToString();
        
        }


        /// <summary>
        /// Busca en el Estante un Producto
        /// </summary>
        /// <param name="e"></param>
        /// <param name="prod"></param>
        /// <returns>true si el producto esta en el estante, de lo contrario false</returns>
        public static bool operator ==(Estante e, Producto prod)
        {            
            foreach (Producto p in e._productos)
            {
                if (p == prod)
                {
                    return true;
                }
            }
            return false;

            
        }

        /// <summary>
        /// Verifica si el producto NO esta en el estante
        /// </summary>
        /// <param name="est"></param>
        /// <param name="prod"></param>
        public static bool operator !=(Estante e, Producto prod)
        {
            return !(e == prod);
        }

        /// <summary>
        /// Agrega Producto al Estante si no exite
        /// </summary>
        /// <param name="e"></param>
        /// <param name="prod"></param>
        /// <returns>true o false</returns>
        public static bool operator +(Estante e, Producto prod)
        {
            if ((e._productos.Count() < (int)e._capacidad)&& (e != prod))
            {        
                e._productos.Add(prod);
                return true;
            }
            
            return false;
            
        }

        /// <summary>
        /// Elinina Producto del Estante si exite
        /// </summary>
        /// <param name="e"></param>
        /// <param name="prod"></param>
        /// <returns>true o false</returns>
        public static Estante operator -(Estante e, Producto prod)
        {
            if (e == prod)
            {                
                e._productos.Remove(prod);
                return e;
            }
            
            return e;
        }

        /// <summary>
        /// Elinina por Tipo de Producto del Estante si exite
        /// </summary>
        /// <param name="e"></param>
        /// <param name="tipo"></param>
        /// <returns>true o false</returns>
        public static Estante operator -(Estante e, ETipoProducto tipo)
        {            
            Estante est = e;

            for (int i = 0; i < e._productos.Count; i++)
            {
                switch (tipo)
                {
                    case ETipoProducto.Galletita:
                        if (est._productos[i] is Galletita)
                        {
                            est -= est._productos[i];
                            i--;
                        }
                        break;
                    case ETipoProducto.Gaseosa:
                        if (est._productos[i] is Gaseosa)
                        {
                            est -= est._productos[i];
                            i--;
                        }
                        break;
                    case ETipoProducto.Jugo:
                        if (est._productos[i] is Jugo)
                        {
                            est -= est._productos[i];
                            i--;
                        }
                        break;
                    case ETipoProducto.Harina:
                        if (est._productos[i] is Jugo)
                        {
                            est -= est._productos[i];
                            i--;
                        }
                        break;
                    case ETipoProducto.Todos:
                        if (e._productos.Count > 0)
                        {
                            est -= est._productos[i];
                            i--;
                        }
                        break;
                }
            }


            return est;
        }

        /// <summary>
        /// Retorna el Total por tipo de Producto
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns>float total</returns>
        public float GetValorEstante(ETipoProducto tipo)
        {
            float total = 0;

            foreach (Producto p in this._productos)
            {
                switch (tipo)
                {
                    case ETipoProducto.Jugo:
                        if (p is Jugo)
                        {
                            total += p.Precio();
                        }
                        break;
                    case ETipoProducto.Gaseosa:
                        if (p is Gaseosa)
                        {
                            total += p.Precio();
                        }
                        break;

                    case ETipoProducto.Galletita:
                        if (p is Galletita)
                        {
                            total += p.Precio();
                        }
                        break;
                    case ETipoProducto.Harina:
                        if (p is Harina)
                        {
                            total += p.Precio();
                        }
                        break; 
                }
            }
         return total;
        }


        /// <summary>
        /// Retorna el total de productos
        /// </summary>
        /// <returns>float</returns>
        public float GetValorEstante()
        {
            float total = 0;

            total += GetValorEstante(ETipoProducto.Jugo);
            total += GetValorEstante(ETipoProducto.Harina);
            total += GetValorEstante(ETipoProducto.Gaseosa);
            total += GetValorEstante(ETipoProducto.Galletita);

            return total;
        }
        
        /// <summary>
        /// Evalua si los objetos son del mismo tipo
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
