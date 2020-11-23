using System;
using Domain;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Microsoft.Extensions.Logging;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest <List<Activity>> {

        }

        public class Handler : IRequestHandler<Query, List<Activity>>
        {
            private readonly DataContext _context;
            private readonly ILogger<List> _logger;

            public Handler(DataContext context, ILogger<List> logger)
            {
                _context = context;
                _logger = logger;
            }
            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                /*try کنسل کردن وسط درخواست
                {
                    for (int i = 0; i < 10; i++)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        await Task.Delay(1000, cancellationToken);
                        _logger.LogInformation($"Task {i} has completed");
                    }
                }
                catch (Exception EX) when (EX is TaskCanceledException)
                {

                    _logger.LogInformation("Task was Cancel");
                }*/

                var activites = await _context.Activities.ToListAsync();
                return activites;
            }
        }
    }
}
