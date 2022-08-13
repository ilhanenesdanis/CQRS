using CQRS.CQRS.Commands;
using CQRS.Data;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.CQRS.Handlers
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
    {
        private readonly StudentContext _context;

        public UpdateStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }


        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var UpdatedStudent = await _context.Students.FindAsync(request.Id);
            UpdatedStudent.Age = request.Age;
            UpdatedStudent.Name = request.Name;
            UpdatedStudent.Surname = request.Surname;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
