using LibraryImplementation.Models;
using PSPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryImplementation
{
    public class Validation
    {

        private static Validation instance;

        public static Validation Instance
        {
            get
            {
                if (instance == null) instance = new Validation();

                return instance;
            }
        }

        public EmailValidator emailValidator = new EmailValidator();
        public PhoneValidator phoneValidator = new PhoneValidator();
        public PasswordValidator passwordValidator = new PasswordValidator();

        /// <summary>
        /// 0- no Errors, 1 - Email Validation Failed, 2 - Pass Validation Failed, 3 - Phone Validation Failed
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int ValidateUser(User user)
        {
            if (!Instance.emailValidator.CheckEmail(user.Email))
            {
                return 1;
            }

            // Password validation is broken in validation lib
/*            if (!Instance.passwordValidator.CheckPassword(user.Password))
            {
                return 2;
            }*/

            if (!Instance.phoneValidator.CheckNumber(user.PhoneNumber))
            {
                return 3;
            }

            return 0;
        }


    }
}
