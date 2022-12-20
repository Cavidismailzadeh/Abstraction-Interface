using Abstraction_Interface.Service.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface.Service
{
    internal class AccountService :IAccount
    {
        public string name;
        public string password;

        public AccountService(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public void sign()
        {
            throw new NotImplementedException();
        }

        internal void Sign()
        {
            if (name == "Akif" && password == "Fazil2001")
            {
                Console.WriteLine("Ugurludur");
            }
            else
            {
                Console.WriteLine("Username ve ya password yanlisdir");
            }
        }

            void IAccount.AccountService()
        {
            throw new NotImplementedException();
        }
    }
}
