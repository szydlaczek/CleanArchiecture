using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exchange.Application.Users.Commands
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Unit>
    {
        public Task<Unit> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
