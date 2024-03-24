using Categorias.Domain.DTOs;
using MediatR;

namespace Categorias.Domain.Commands.ObterCategoria
{
    public class ObterCategoriaRequest : IRequest<CommandResponse>
    {
        public Guid Id { get; }

        public ObterCategoriaRequest(Guid id)
        {
            Id = id;
        }
    }
}
