using Financiera2019.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Financiera2019.Infraestructura.Datos.EF.Mapeos
{
    public class MovimientoCuentaMapeo : EntityTypeConfiguration<MovimientoCuenta>
    {
        public MovimientoCuentaMapeo()
        {
            ToTable("TBL_MOVIMIENTOS");
            HasKey(k => k.NumeroMovimiento);
            Property(p => p.NumeroMovimiento).IsRequired();
            Property(p => p.IdentificadorCuenta).IsRequired();
            Property(p => p.FechaMovimiento).IsRequired();
            Property(p => p.CodigoTipoOperacion).IsRequired();
            Property(p => p.EstadoMovimiento).IsRequired();
            Property(p => p.MontoMovimiento).IsRequired();

            HasRequired(p => p.Cuenta).WithMany().HasForeignKey(f => f.IdentificadorCuenta);

        }
    }
}
