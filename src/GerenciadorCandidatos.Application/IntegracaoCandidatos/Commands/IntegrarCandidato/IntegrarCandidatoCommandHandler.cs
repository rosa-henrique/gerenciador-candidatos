using MediatR;

namespace GerenciadorCandidatos.Application.IntegracaoCandidatos.Commands.IntegrarCandidato;

public class IntegrarCandidatoCommandHandler : IRequestHandler<IntegrarCandidatoCommand, string>
{
    public Task<string> Handle(IntegrarCandidatoCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult("sucesso");
    }
}
