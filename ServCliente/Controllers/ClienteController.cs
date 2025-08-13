using Application.DTOs;
using Application.DTOs.Requests;
using Application.DTOs.Responses;
using Application.Interfaces;
using Domain.Consts;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ServCliente.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        [Route(GlobalConstantHelpers.TAG_CGA_METHOD_GETALL)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ClienteDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(Summary = GlobalConstantSwagger.TAG_CGA_METHOD_DESC)]

        public async Task<ActionResult> GetAll()
        {
            var clientes = await _clienteService.ObtenerTodosAsync();

            return Ok(clientes);
        }

        [HttpGet]
        [Route(GlobalConstantHelpers.TAG_CGID_METHOD_DESC_GETBYID)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ClienteDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(Summary = GlobalConstantSwagger.TAG_CGID_METHOD_DESC)]
        public async Task<ActionResult> ById(int id)
        {
            var cliente = await _clienteService.ObtenerPorIdAsync(id);

            if (cliente == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, new { Message = $"{GlobalConstantMessages.MSG_CGID_METHOD_DESC} {id}"});
            }

            return Ok(cliente);
        }

        [HttpPost]
        [Route(GlobalConstantHelpers.TAG_CC_METHOD_DESC_CREATE)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ClienteDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(Summary = GlobalConstantSwagger.TAG_CC_METHOD_DESC)]
        public async Task<ActionResult> Create([FromBody] ClienteCrdDto request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var creado = await _clienteService.CrearClienteAsync(request);

            return Ok(creado);
        }

        [HttpPut]
        [Route(GlobalConstantHelpers.TAG_CUPD_METHOD_DESC_UPD)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(Summary = GlobalConstantSwagger.TAG_CUPD_METHOD_DESC)]
        public async Task<ActionResult> Update(int id, [FromBody] ClienteUpdDto request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var actualizado = await _clienteService.ActualizarClienteAsync(id, request);

            return Ok(actualizado);
        }

        [HttpDelete]
        [Route(GlobalConstantHelpers.TAG_CD_METHOD_DESC_DEL)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [SwaggerOperation(Summary = GlobalConstantSwagger.TAG_CD_METHOD_DESC)]
        public async Task<ActionResult> Delete(int id)
        {
            var eliminado = await _clienteService.EliminarClienteAsync(id);

            return Ok(eliminado);
        }
    }
}
