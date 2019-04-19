using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.NetCore
{
    public class UserCommand : INotification
    {
        public NewUser newuser { get; set; }
    }
}
