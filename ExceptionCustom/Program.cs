using System;
using System.Runtime.Serialization;

namespace ExceptionCustom
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() 
            : base()
        {

        }
        public UserAlreadyLoggedInException(string? message) 
            : base(message)
        {

        }
        public UserAlreadyLoggedInException(string? message, Exception innerException) 
            : base(message, innerException)
        {

        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {

        }
    }
}
