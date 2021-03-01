using System;

namespace dot.domainExeception
{
    public class DomainExecption : ApplicationException
    {
        public DomainExecption(string message) : base(message)
        {
        }
    }
}