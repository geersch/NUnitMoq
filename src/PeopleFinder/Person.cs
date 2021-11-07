using System.Collections.Generic;

namespace PeopleFinder
{
    public abstract class DomainObject
    { }

    public class Person : DomainObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}