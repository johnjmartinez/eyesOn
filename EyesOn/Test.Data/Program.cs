using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EyesOn.Data;
using EyesOn.Data.Model.Server;

namespace Test.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetUsers();

            //AddUser();

            AddPhoto();
        }

        static void GetUsers()
        {
            using (Context context = new Context())
            {
                var users = context.Users.ToList();
                foreach(var u in users)
                {
                    Console.WriteLine(u.Id);
                }
            }
        }

        static void AddUser()
        {
            using (Context context = new Context())
            {
                User u = new User();
                u.Id = 1;
                u.Email = "andrew@davisfiles.net";
                u.Password = "password";
                u.Name = "Andrew";

                context.Users.Add(u);
                context.SaveChanges();
            }
        }

        static void AddPhoto()
        {
            using (Context context = new Context())
            {
                Photo p = new Photo();
                p.Id = context.Photos.Count() + 1;
                p.SubmittedBy = context.Users.Where(x => x.Id == 1).SingleOrDefault();
                
                context.Photos.Add(p);
                context.SaveChanges();
            }
        }
    }
}
