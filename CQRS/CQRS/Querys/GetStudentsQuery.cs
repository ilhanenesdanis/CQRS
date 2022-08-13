using CQRS.CQRS.Results;
using MediatR;
using System.Collections.Generic;

namespace CQRS.CQRS.Querys
{
    public class GetStudentsQuery:IRequest<IEnumerable<GetStudentsQueryResults>>
    {
    }
}
