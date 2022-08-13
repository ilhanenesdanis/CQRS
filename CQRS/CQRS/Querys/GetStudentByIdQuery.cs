using CQRS.CQRS.Results;
using MediatR;

namespace CQRS.CQRS.Querys
{
    public class GetStudentByIdQuery:IRequest<GetStudentByIdGetResult>
    {
        public int Id { get; set; }

        public GetStudentByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
