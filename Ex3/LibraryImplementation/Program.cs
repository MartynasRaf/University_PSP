using LibraryImplementation.Data;
using System;
using System.IO;
using System.Threading;

namespace LibraryImplementation
{
    public class Program
    {

        static void Main(string[] args)
        {
            Users users = new Users();

            int k = users.SaveUser(new Models.User() { Email = "fs@fs.com", Password = "dasf498@FA#$44", PhoneNumber = "862030741" }).Result;

            var t = users.GetAllUsers().Result;

        }




    }
}
