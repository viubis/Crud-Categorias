using MediatR;
using prmToolkit.NotificationPattern;
using Categorias.Domain.DTOs;
using Categorias.Domain.Commands.Categorias.Adicionar;
using Categorias.Domain.Interfaces.Repositorios;
using Categorias.Domain.Entidades;
using Categorias.Infra.CrossCutting.Constantes;

namespace Categorias.Domain.Commands.AdicionarCategoria
{
    public class AdicionarCategoriaHandler : Notifiable, IRequestHandler<AdicionarCategoriaRequest, CommandResponse>
    {
        private readonly IRepositorioCategoria _repositorioCategoria;

        public AdicionarCategoriaHandler(IRepositorioCategoria repositorioCategoria)
        {
            _repositorioCategoria = repositorioCategoria;
        }

        public Task<CommandResponse> Handle(AdicionarCategoriaRequest request, CancellationToken cancellationToken)
        {

            if (request is null)
            {
                AddNotification(Notificacoes.CATEGORIA_MODULO, Notificacoes.REQUISICAO_INVALIDA);
                return Task.FromResult(new CommandResponse(this));
            }

            var categoria = new Categoria(request.Codigo, request.Titulo, request.Descricao);
            AddNotifications(categoria);

            if (IsInvalid())
            {
                return Task.FromResult(new CommandResponse(this));
            }

            _repositorioCategoria.Add(categoria);
            _repositorioCategoria.Commit();

            var AddResponse = new AdicionarCategoriaResponse(categoria.Id, Notificacoes.CATEGORIA_ADICIONAR);
            return Task.FromResult(new CommandResponse(AddResponse, this));
        }
    }
}
