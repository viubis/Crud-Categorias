using MediatR;
using Categorias.Domain.DTOs;

namespace Categorias.Domain.Commands.Categorias.Adicionar
{
    public class AdicionarCategoriaRequest : IRequest<CommandResponse>
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
    }
}
