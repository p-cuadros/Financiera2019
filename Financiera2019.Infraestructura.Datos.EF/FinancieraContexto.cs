using Financiera2019.Dominio.Entidades;
using System.Data.Entity;

namespace Financiera2019.Infraestructura.Datos.EF
{
    public class FinancieraContexto : DbContext
    {
        public FinancieraContexto() : base("Financiera")
        {
        }
        public IDbSet<Cliente> Clientes { get; set; }
        public IDbSet<CuentaAhorro> Cuentas { get; set; }
        public IDbSet<MovimientoCuenta> Movimiento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
