using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EyesOn.Data.Model.Server;

namespace EyesOn.Data.Model.Requests
{
    public class LoginResult
    {
        public Guid Id { get; set; }
        public bool Result { get; set; }
        public User User { get; set; }
    }
}
