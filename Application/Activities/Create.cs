using Domain;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class Create
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public DateTime Date { get; set; }

            public string City { get; set; }
            public string Venue { get; set; }


            public class Handler : IRequestHandler<Command>
            {
                private readonly DataContext _contex;

                public Handler(DataContext contex)
                {
                    _contex = contex;
                }

                public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
                {
                    var Add = new Activity
                    {
                        Id = request.Id,
                        Category = request.Category,
                        City = request.City,
                        Date = request.Date,
                        Description = request.Description,
                        Title = request.Title,
                        Venue = request.Venue

                    };
                    _contex.Activities.Add(Add);
                    var success = await _contex.SaveChangesAsync() > 0;
                    if (success)
                    {
                        return Unit.Value;
                    }

                    throw new Exception("Problem saving changes");
                }
            }

        }
    }
}

