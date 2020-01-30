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
            public Guid Id { get; set; }    // Guid allows us to create the Id either from the server or client side code
            public string Title { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public DateTime Date { get; set; }
            public string City { get; set; }
            public string Venue { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            // MediatR.Unit is an empty object
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var activity = new Activity
                {
                    Id = request.Id,
                    Title = request.Title,
                    Description = request.Description,
                    Category = request.Category,
                    Date = request.Date,
                    City = request.City,
                    Venue = request.Venue
                };
                _context.Activities.Add(activity);
                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;     // return to API controller, with a 200 OK response when it receives the empty object

                throw new Exception("Problem saving changes");
            }
        }
    }
}
