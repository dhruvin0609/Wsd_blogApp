using System;
using System.Threading;

namespace bolgAppClient
{
    public static class SessionManager
    {
        private static int userId;
        private static DateTime expirationTime;

        // Expiration time in minutes
        private const int SessionExpirationMinutes = 10;

        public static int UserId
        {
            get
            {
                // Check if session has expired
                if (DateTime.Now > expirationTime)
                {
                    userId = -1; // Reset email
                }
                
                return userId;
            }
            set
            {
                userId = value;
                // Set expiration time
                expirationTime = DateTime.Now.AddMinutes(SessionExpirationMinutes);
            }
        }

        // Method to check if session is expired
        public static bool IsSessionExpired()
        {
            return DateTime.Now > expirationTime;
        }
    }
}
