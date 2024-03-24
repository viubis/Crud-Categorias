namespace Categorias.Domain.Commands.ListarCategorias
{

    public class ListarCategoriaResponse
    {
        public int QuantidadeRegistros { get; }
        public List<ListaCategoriaDetalheResponse> Categorias { get; set; }

        public ListarCategoriaResponse(int quantidadeRegistros, List<ListaCategoriaDetalheResponse> categorias)
        {
            QuantidadeRegistros = quantidadeRegistros;
            Categorias = categorias;
        }

    }
    public class ListaCategoriaDetalheResponse
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Titulo { get; }
        public string Descricao { get; }
        public ListaCategoriaDetalheResponse(Guid id, int codigo, string titulo, string descricao)
        {
            Id = id;
            Codigo = codigo;
            Titulo = titulo;
            Descricao = descricao;
        }
    }
}
