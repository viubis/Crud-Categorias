using Categorias.Domain.Entidades;

namespace Categorias.Domain.Entidades
{
    public class Categoria : EntidadeBase
    {
        public int Codigo { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }

        protected Categoria() {}

        public Categoria (int codigo, string titulo, string descricao)
        {
            Codigo = codigo;
            Titulo = titulo;
            Descricao = descricao;
        }
        

        public void Update (int codigo, string titulo, string descricao)
        {
            Codigo = codigo;
            Titulo = titulo;
            Descricao = descricao;

        }
    }
}
