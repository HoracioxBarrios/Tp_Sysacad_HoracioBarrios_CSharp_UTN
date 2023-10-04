using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Utilidades
{
    internal class PasswordHashing
    {
        public static string GetHash(string password)
        {
            var hash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 8);
            return hash;
        }

        public static bool ValidatePassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hash);
        }

    }
}
