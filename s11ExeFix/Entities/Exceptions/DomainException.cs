using System;
namespace s11ExeFix.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base (message)
        {
        }
    }
}
