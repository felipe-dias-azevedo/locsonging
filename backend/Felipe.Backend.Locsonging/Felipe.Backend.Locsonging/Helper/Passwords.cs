using System;

namespace Felipe.Backend.Locsonging.Helper
{
    public static class Passwords
    {
        public static bool Validate(string password, string passwordStored)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordStored))
            {
                throw new InvalidOperationException();
            }

            // TODO: Validate by bcrypt

            return password == passwordStored;
        }
    }
}
