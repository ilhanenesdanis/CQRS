using CQRS.CQRS.Querys;
using CQRS.CQRS.Results;
using CQRS.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.CQRS.Handlers
{
    public class GetStudentsQueryHandler:IRequestHandler<GetStudentsQuery,IEnumerable<GetStudentsQueryResults>>
    {
        private readonly StudentContext _context;

        public GetStudentsQueryHandler(StudentContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<GetStudentsQueryResults>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            return  await _context.Students.Select(x => new GetStudentsQueryResults { Name = x.Name, Surname = x.Surname }).AsNoTracking().ToListAsync();

        }
    }
}
