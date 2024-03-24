namespace Categorias.Domain.Commands.ObterCategoria
{
    public class ObterCategoriaResponse
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }


        public ObterCategoriaResponse(Guid id, int codigo, string titulo, string descricao)
        {
            Id = id;
            Codigo = codigo;
            Titulo = titulo;
            Descricao = descricao;
        }
    }
}
