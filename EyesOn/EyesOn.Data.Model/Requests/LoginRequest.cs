using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EyesOn.Data.Model.Requests
{
    public class LoginRequest
    {
        public Guid Id { get; set; }
        public UserCredentials Credentials { get; set; }
    }
}
