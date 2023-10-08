using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCLases.Utilidades
{
    /// <summary>
    /// Clase que proporciona métodos para el hashing y validación de contraseñas.
    /// </summary>
    internal class PasswordHashing
    {
        /// <summary>
        /// Genera un hash para una contraseña dada.
        /// </summary>
        /// <param name="password">La contraseña a hashear.</param>
        /// <returns>El hash de la contraseña.</returns>
        public static string GetHash(string password)
        {
            var hash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 8);
            return hash;
        }

        /// <summary>
        /// Valida si una contraseña coincide con un hash dado.
        /// </summary>
        /// <param name="password">La contraseña a validar.</param>
        /// <param name="hash">El hash contra el cual se compara la contraseña.</param>
        /// <returns>True si la contraseña coincide con el hash; de lo contrario, false.</returns>
        public static bool ValidatePassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hash);
        }

    }
}
