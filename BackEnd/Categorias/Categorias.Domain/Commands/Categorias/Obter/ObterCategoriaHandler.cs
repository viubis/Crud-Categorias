using Categorias.Domain.DTOs;
using Categorias.Domain.Interfaces.Repositorios;
using Categorias.Infra.CrossCutting.Constantes;
using MediatR;
using prmToolkit.NotificationPattern;

namespace Categorias.Domain.Commands.ObterCategoria
{
    public class ObterCategoriaHandler : Notifiable, IRequestHandler<ObterCategoriaRequest, CommandResponse>
    {
        private readonly IRepositorioCategoria _repositorioCategoria;

        public ObterCategoriaHandler(IRepositorioCategoria repositorioCategoria)
        {
            _repositorioCategoria = repositorioCategoria;
        }

        
        public Task<CommandResponse> Handle(ObterCategoriaRequest request, CancellationToken cancellationToken)
        {
            if(request is null)
            {
                AddNotification(Notificacoes.CATEGORIA_MODULO, Notificacoes.REQUISICAO_INVALIDA);
                return Task.FromResult(new CommandResponse(this));
            }

            var categoria = _repositorioCategoria.Get(request.Id);

            if(categoria is null)
            {
                AddNotification(Notificacoes.CATEGORIA_MODULO, Notificacoes.CATEGORIA_NAO_LOCALIZADA);
                return Task.FromResult(new CommandResponse(this));
            }

            return Task.FromResult(
                new CommandResponse(
                    new ObterCategoriaResponse(
                        categoria.Id,
                        categoria.Codigo,
                        categoria.Titulo,
                        categoria.Descricao),this)); 
        }
    }
}
