using Financiera2019.Dominio.Repositorios;
using System.Linq;

namespace Financiera2019.Infraestructura.Datos.EF.Repositorios
{
    public class Repositorio : IRepositorio
    {
        readonly FinancieraContexto ioContexto;
        public Repositorio()
        {
            ioContexto = new FinancieraContexto();
        }
        public T ObtenerPorCodigo<T>(params object[] aoLLaves) where T : class
        {
            return ioContexto.Set<T>().Find(aoLLaves);
        }
        public IQueryable<T> Listar<T>(string asPropiedades = "") where T : class
        {
            return ioContexto.Set<T>();
        }
        public void Adicionar<T>(T aoEntidad) where T : class
        {
            ioContexto.Set<T>().Add(aoEntidad);
        }
        public void GuardarCambios()
        {
            ioContexto.SaveChanges();
        }
    }
}
