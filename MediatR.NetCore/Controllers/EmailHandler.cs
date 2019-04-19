using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.NetCore.Controllers
{
    public class EmailHandler : INotificationHandler<UserCommand>
    {
        public Task Handle(UserCommand notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("`````   send email `  ```````````" + notification.username);
            return Task.FromResult(true);
        }
    }
}
