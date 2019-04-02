using Financiera2019.Dominio.Entidades;
using Financiera2019.Infraestructura.Datos.EF.Mapeos;
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
            modelBuilder.Configurations.Add(new ClienteMapeo());
            modelBuilder.Configurations.Add(new CuentaAhorroMapeo());
            modelBuilder.Configurations.Add(new MovimientoCuentaMapeo());
        }
    }
}
