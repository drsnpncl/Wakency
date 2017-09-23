using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace Wakency
{
    public class Program
    {
        public void btnClk()
        {
            var Context = new DatabaseEntities();
            var post = new user()
            {
                fname = "sample",
                lname = "from",
                email = "program@gmail.com",
                contact = "7878787878",
                username = "sample",
                password = "sample",
                dept = "computer",
                date_of_creation = DateTime.Now,
                
            };
            Context.users.Add(post);
            Context.SaveChanges();

        }
    }
}