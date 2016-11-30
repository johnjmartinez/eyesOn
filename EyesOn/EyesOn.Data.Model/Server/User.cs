using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EyesOn.Data.Model.Server
{
    public class User
    {
        //key
        public int Id { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }

        public virtual List<Photo> Photos { get; set; }
    }
}
