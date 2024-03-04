using MediatR;

namespace GerenciadorCandidatos.Application.IntegracaoCandidatos.Commands.IntegrarCandidato;

public record IntegrarCandidatoCommand() : IRequest<string>;
