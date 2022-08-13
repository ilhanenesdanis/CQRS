using CQRS.CQRS.Querys;
using CQRS.CQRS.Results;
using CQRS.Data;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.CQRS.Handlers
{
    public class GetStudentByIdQueryHandler:IRequestHandler<GetStudentByIdQuery,GetStudentByIdGetResult>
    {
        private readonly StudentContext _context;

        public GetStudentByIdQueryHandler(StudentContext context)
        {
            _context = context;
        }
        public async Task<GetStudentByIdGetResult> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _context.Set<Student>().FindAsync(request.Id);
            return new GetStudentByIdGetResult
            {
                Age = student.Age,
                Name = student.Name,
                Surname = student.Surname,
            };
        }
    }
}
