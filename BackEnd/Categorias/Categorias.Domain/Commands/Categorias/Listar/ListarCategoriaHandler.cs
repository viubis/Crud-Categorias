using Categorias.Domain.DTOs;
using Categorias.Domain.Interfaces.Repositorios;
using MediatR;
using prmToolkit.NotificationPattern;

namespace Categorias.Domain.Commands.ListarCategorias
{
    public class ListarCategoriaHandler : Notifiable, IRequestHandler<ListarCategoriaRequest, CommandResponse>
    {
        private readonly IRepositorioCategoria _repositorioCategoria;

        public ListarCategoriaHandler(IRepositorioCategoria repositorioCategoria)
        {
            _repositorioCategoria = repositorioCategoria;
        }   

        public Task<CommandResponse> Handle(ListarCategoriaRequest request, CancellationToken cancellationToken)
        {
            var listaCategoria = _repositorioCategoria.List();

            var listaCategoriaResponse = listaCategoria.Select(categoria => new ListaCategoriaDetalheResponse
                (categoria.Id,
                 categoria.Codigo,
                 categoria.Titulo,
                 categoria.Descricao)).ToList();

            var listarCategoriaResponse = new ListarCategoriaResponse(listaCategoria.Count(), listaCategoriaResponse);

            return Task.FromResult(new CommandResponse(listaCategoriaResponse, this));
         
        }
    }
}
