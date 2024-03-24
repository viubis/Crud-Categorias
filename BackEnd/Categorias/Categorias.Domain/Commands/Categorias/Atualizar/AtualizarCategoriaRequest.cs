using MediatR;
using Categorias.Domain.DTOs;

namespace Categorias.Domain.Commands.AtualizarCategoria
{
    public class AtualizarCategoriaRequest : IRequest<CommandResponse>
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
