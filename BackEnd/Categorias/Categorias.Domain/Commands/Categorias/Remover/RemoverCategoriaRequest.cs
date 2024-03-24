using Categorias.Domain.DTOs;
using MediatR;

namespace Categorias.Domain.Commands.RemoverCategoria
{
    public class RemoverCategoriaRequest : IRequest<CommandResponse>
    {
        public Guid Id { get; }

        public RemoverCategoriaRequest(Guid id)
        {
            Id = id;
        }
    }
}
