using Financiera2019.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Financiera2019.Infraestructura.Datos.EF.Mapeos
{
    public class CuentaAhorroMapeo : EntityTypeConfiguration<CuentaAhorro>
    {
        public CuentaAhorroMapeo()
        {
            ToTable("TBL_CUENTAS");
        }
    }
}
