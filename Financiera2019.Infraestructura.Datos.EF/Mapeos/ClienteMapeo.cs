using Financiera2019.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Financiera2019.Infraestructura.Datos.EF.Mapeos
{
    public class ClienteMapeo : EntityTypeConfiguration<Cliente>
    {
        public ClienteMapeo()
        {
            ToTable("TBL_CLIENTES");
            HasKey(k => k.CodigoCliente);
            Property(p => p.CodigoCliente).IsRequired();
            Property(p => p.NombreCliente).IsRequired().HasMaxLength(100);
            Property(p => p.FechaRegistro).IsRequired();
        }
    }
}
