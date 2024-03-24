using Categorias.Domain.DTOs;
using Categorias.Domain.Interfaces.Repositorios;
using Categorias.Infra.CrossCutting.Constantes;
using MediatR;
using prmToolkit.NotificationPattern;

namespace Categorias.Domain.Commands.RemoverCategoria
{
    public class RemoverCategoriaHandler : Notifiable, IRequestHandler<RemoverCategoriaRequest, CommandResponse> 
    {
        private readonly IRepositorioCategoria _repositorioCategoria;

        public RemoverCategoriaHandler(IRepositorioCategoria repositorioCategoria)
        {
            _repositorioCategoria = repositorioCategoria;
        }

        public Task<CommandResponse> Handle(RemoverCategoriaRequest request, CancellationToken cancellationToken)
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

      
            _repositorioCategoria.Delete(categoria);
        
            _repositorioCategoria.Commit();

            return Task.FromResult(new CommandResponse(new RemoverCategoriaResponse(Notificacoes.CATEGORIA_REMOVER), this));

        }
    }
}
