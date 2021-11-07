using System.Collections.Generic;

namespace PeopleFinder
{
    public interface IRepository<out T> where T : DomainObject
    {
        IEnumerable<T> GetAll();
    }

    public class PersonRepository : IRepository<Person>
    {
        private static IEnumerable<Person> _people;

        private static IEnumerable<Person> GetPeople()
        {
            if (_people != null) return _people;

            _people = new List<Person>
            {
                new Person {FirstName = "John", LastName = "Doe"},
                new Person {FirstName = "Jane", LastName = "Doe"},
                new Person {FirstName = "John", LastName = "Smith"},
                new Person {FirstName = "Matthew", LastName = "MacDonald"},
                new Person {FirstName = "Andrew", LastName = "MacDonald"}
            };

            return _people;
        }

        public IEnumerable<Person> GetAll()
        {
            return GetPeople();
        }
    }
}