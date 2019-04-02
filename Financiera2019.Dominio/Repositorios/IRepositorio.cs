using System.Linq;

namespace Financiera2019.Dominio.Repositorios
{
    public interface IRepositorio
    {
        T ObtenerPorCodigo<T>(params object[] aoLLaves) where T : class;
        IQueryable<T> Listar<T>(string asPropiedades = "") where T : class;
        void Adicionar<T>(T aoEntidad) where T : class;
        void GuardarCambios();
    }
}
