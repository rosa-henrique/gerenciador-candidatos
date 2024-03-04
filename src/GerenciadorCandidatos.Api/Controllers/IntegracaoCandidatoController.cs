using GerenciadorCandidatos.Application.IntegracaoCandidatos.Commands.IntegrarCandidato;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorCandidatos.Api.Controllers;

[Route("integracao-candidato")]
public class IntegracaoCandidatoController(ISender _mediator) : ApiController
{
    [HttpPost("integrar")]
    public async Task Integrar()
    {
        var resultado = await _mediator.Send(new IntegrarCandidatoCommand());
    }
}
