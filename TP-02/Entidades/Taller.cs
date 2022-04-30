using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public class Taller
    {
        List<Vehiculo> vehiculos;
        int espacioDisponible;
        public enum ETipo
        {
            Moto, Automovil, Camioneta, Todos
        }

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            foreach (Vehiculo v in taller.vehiculos)
            {
                //if (tipo != ETipo.Todos)
                //{
                    switch (tipo)
                    {
                        case ETipo.Camioneta:
                            if(v.Tamanio == Vehiculo.ETamanio.Grande)
                                sb.AppendLine(v.Mostrar());
                                break;
                        case ETipo.Moto:
                            if (v.Tamanio == Vehiculo.ETamanio.Chico)
                                sb.AppendLine(v.Mostrar());
                                break;
                        case ETipo.Automovil:
                            if (v.Tamanio == Vehiculo.ETamanio.Mediano)
                                sb.AppendLine(v.Mostrar());
                            break;
                        default:
                            sb.AppendLine(v.Mostrar());
                            break;
                    }
                //}
                //else
                  //  sb.AppendLine(v.Mostrar());
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            bool flag = false;
            if (taller.vehiculos.Count < taller.espacioDisponible)
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        flag = true;
                        break;
                    }
                }
                if(!flag)
                    taller.vehiculos.Add(vehiculo);
            }
            return taller;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            int tam = taller.vehiculos.Count;
            for(int i= 0; i < tam;i++)
            {
                if (taller.vehiculos[i] == vehiculo)
                {
                    taller.vehiculos.RemoveAt(i);
                    break;
                }
            }
            return taller;
        }
        #endregion
    }
}
