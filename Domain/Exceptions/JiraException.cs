using System;

namespace Domain.Exceptions
{
    public class JiraException : Exception
    {
        public JiraException()
        {
        }

        public JiraException(string message) : base(message)
        {
        }

        public JiraException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
