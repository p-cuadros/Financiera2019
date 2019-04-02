using Financiera2019.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Financiera2019.Infraestructura.Datos.EF.Mapeos
{
    public class CuentaAhorroMapeo : EntityTypeConfiguration<CuentaAhorro>
    {
        public CuentaAhorroMapeo()
        {
            ToTable("TBL_CUENTAS");
            HasKey(k => k.IdentificadorCuenta);
            Property(p => p.IdentificadorCuenta).IsRequired();
            Property(p => p.NumeroCuenta).IsRequired().HasMaxLength(10);
            Property(p => p.CodigoCliente).IsRequired();
            Property(p => p.EstadoCuenta).IsRequired();
            Property(p => p.FechaCreacion).IsRequired();
            Property(p => p.Saldo).IsRequired();

            HasRequired(p => p.Propietario).WithMany().HasForeignKey(f => f.CodigoCliente);
        }
    }
}
