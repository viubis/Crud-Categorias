namespace Categorias.Domain.Commands.AtualizarCategoria
{
    public class AtualizarCategoriaResponse
    {
        public string Message { get; }

        public AtualizarCategoriaResponse(string message)
        {
            Message = message;
        }   
    }
}
