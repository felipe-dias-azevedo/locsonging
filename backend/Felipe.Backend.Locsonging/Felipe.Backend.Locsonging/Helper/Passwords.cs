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

            // TODO: Validate by bcrypt and base64

            return password == passwordStored;
        }

        public static string ToPassword(string password)
        {
            // TODO: Set bcrypt and base64
            return password;
        }
    }
}
