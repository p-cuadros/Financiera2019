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
            Property(p => p.NumeroMovimiento).HasColumnName("NUM_MOVIMIENTO").IsRequired();
            Property(p => p.IdentificadorCuenta).HasColumnName("ID_CUENTA").IsRequired();
            Property(p => p.CodigoTipoOperacion).HasColumnName("COD_TIPO_OPER").IsRequired();
            Property(p => p.FechaMovimiento).HasColumnName("FEC_MOVIMIENTO").IsRequired();
            Property(p => p.EstadoMovimiento).HasColumnName("EST_MOVIMIENTO").IsRequired();
            Property(p => p.MontoMovimiento).HasColumnName("MON_MOVIMIENTO").IsRequired();

            HasRequired(m => m.Cuenta).WithMany().HasForeignKey(f => f.IdentificadorCuenta);

        }
    }
}
