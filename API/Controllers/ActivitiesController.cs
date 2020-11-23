using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Domain;
using Application.Activities;
using System.Threading;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ActivitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

       /* [HttpGet]  کنسل کردن در وسط درخواست
        public async Task<ActionResult<List<Activity>>> List(CancellationToken ct) {
            return await _mediator.Send(new List.Query(),ct);
        
        }*/

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> List()
        {
            return await _mediator.Send(new List.Query());

        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> Detials(Guid id)
        {
            return await _mediator.Send(new Detials.Query { Id=id });

        }
        [HttpPost]
        public async Task<ActionResult<Unit>> Create(Create.Command command)
        {

            return await _mediator.Send(command);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Edit(Guid id,Edit.Command command)
        {
            command.Id = id;
            return await _mediator.Send(command);

        }
    }
}
