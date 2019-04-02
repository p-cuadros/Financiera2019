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
            Property(p => p.IdentificadorCuenta).HasColumnName("ID_CUENTA").IsRequired();
            Property(p => p.NumeroCuenta).HasColumnName("NUM_CUENTA").IsRequired().HasMaxLength(10);
            Property(p => p.CodigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
            Property(p => p.EstadoCuenta).HasColumnName("EST_CUENTA").IsRequired();
            Property(p => p.FechaApertura).HasColumnName("FEC_APERTURA").IsRequired();
            Property(p => p.Saldo).HasColumnName("MON_SALDO").IsRequired();

            HasRequired(p => p.Propietario).WithMany().HasForeignKey(f => f.CodigoCliente);
        }
    }
}
