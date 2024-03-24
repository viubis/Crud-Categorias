namespace Categorias.Domain.Commands.Categorias.Adicionar
{
    public class AdicionarCategoriaResponse
    {
        public Guid Id { get; }
        public string Message { get; }

        public AdicionarCategoriaResponse(Guid id, string message) 
        {
            Id = id;
            Message = message;
        }
    }
}
