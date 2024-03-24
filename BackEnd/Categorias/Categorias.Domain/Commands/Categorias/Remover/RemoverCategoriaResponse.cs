namespace Categorias.Domain.Commands.RemoverCategoria
{
    public class RemoverCategoriaResponse
    {
        public string Message { get; }

        public RemoverCategoriaResponse(string message)
        {
            Message = message;
        }
    }
}
