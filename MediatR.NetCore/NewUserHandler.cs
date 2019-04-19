using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.NetCore
{
    public class NewUserHandler : INotificationHandler<UserCommand>
    {
        public Task Handle(UserCommand notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("******   save new user  *******");
            throw new NotImplementedException();
        }

       
    }
}
