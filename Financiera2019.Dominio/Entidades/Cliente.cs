using System;

namespace Financiera2019.Dominio.Entidades
{
    /// <summary>
    /// Clase de Dominio que representa a un Cliente
    /// </summary>
    public class Cliente //: EntidadBase
    {
        #region Propiedades
        /// <summary>
        /// Propiedad que representa el Código del Cliente
        /// </summary>
        public int CodigoCliente { get; private set; }
        /// <summary>
        /// Propiedad que representa el Nombre del Cliente
        /// </summary>
        public string NombreCliente { get; private set; }
        /// <summary>
        /// Propiedad que representa la Fecha de Registro del Cliente
        /// </summary>
        public DateTime FechaRegistro { get; private set; }

        #endregion

        #region Métodos / Operaciones
        /// <summary>
        /// Metodo para crear un nuevo cliente
        /// </summary>
        /// <param name="aiCodigoCliente">Código del Cliente</param>
        /// <param name="asNombreCliente">Nombre del cliente</param>
        /// <returns>Instancia nueva de la clase Cliente</returns>
        public static Cliente Crear(int aiCodigoCliente, string asNombreCliente)
        {
            return new Cliente()
            {
                CodigoCliente = aiCodigoCliente,
                NombreCliente = asNombreCliente,
                FechaRegistro = DateTime.Now
            };
        }
        /// <summary>
        /// Metodo que permite cambiar el nombre del cliente
        /// </summary>
        /// <param name="asNombreCliente">Nombre del cliente a cambiar</param>
        public void CambiarNombre(string asNombreCliente)
        {
            NombreCliente = asNombreCliente;
        }

        #endregion
    }
}
