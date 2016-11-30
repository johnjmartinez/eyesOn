using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EyesOn.Data.Model.Server
{
    public class Photo
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public virtual User SubmittedBy { get; set; }
    }
}
