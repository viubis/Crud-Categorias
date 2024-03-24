﻿using Categorias.Domain.DTOs;
using Categorias.Domain.Interfaces.Repositorios;
using Categorias.Infra.CrossCutting.Constantes;
using MediatR;
using prmToolkit.NotificationPattern;

namespace Categorias.Domain.Commands.AtualizarCategoria
{
    public class AtualizarCategoriaHandler : Notifiable, IRequestHandler<AtualizarCategoriaRequest, CommandResponse>
    {
        private readonly IRepositorioCategoria _repositorioCategoria;

        public AtualizarCategoriaHandler(IRepositorioCategoria repositorioCategoria)
        {
            _repositorioCategoria = repositorioCategoria;
        }

        public Task<CommandResponse> Handle(AtualizarCategoriaRequest request, CancellationToken cancellationToken)
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

            categoria.Update(request.Codigo, request.Titulo, request.Descricao);

            _repositorioCategoria.Update(categoria);
            _repositorioCategoria.Commit();

            return Task.FromResult(new CommandResponse(new AtualizarCategoriaResponse(Notificacoes.CATEGORIA_ATUALIZAR), this));
        } 
    }
}
