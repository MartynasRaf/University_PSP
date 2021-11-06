using LibraryImplementation.Data;
using LibraryImplementation.Models;
using PSPLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LibraryImplementation
{
    public class Users
    {

        private EmailValidator emailValidator = new EmailValidator();
        private PasswordValidator passwordValidator = new PasswordValidator();
        private PhoneValidator phoneValidator = new PhoneValidator();
        
        public async Task<int> SaveUser(User user)
        {
            int exitCode = Validation.ValidateUser(user);

            if (exitCode != 0) return exitCode;

            await UserDatabase.Instance.SaveUserAsync(user);

            return 0;
        }


        public async Task<int> SaveUser(int id,User user)
        {

            int exitCode = Validation.ValidateUser(user);

            if (exitCode != 0) return exitCode;

            user.ID = id;

            await UserDatabase.Instance.SaveUserAsync(user);

            return exitCode;
        }

        public async Task<User> GetUser(int id)
        {
            return await UserDatabase.Instance.GetUserAsync(id);
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await UserDatabase.Instance.GetUsersAsync();
        }

        public async Task<int> DeleteUser(User user)
        {
            return await UserDatabase.Instance.DeleteUserAsync(user);
        }

        public async Task<int> DeleteUser(int id)
        {
            User user = await GetUser(id);

            return await UserDatabase.Instance.DeleteUserAsync(user);
        }

        public async Task<int> DeleteAll()
        {
            return await UserDatabase.Instance.DeleteAllAsync();
        }

    }
}
