using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET5
{
    public class Person
    {
        public Person()
        {
        }

        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Person(int id, string name, int age) : this(id, name)
        {
            Age = age;
        }

        // init - dzieki temu możemy tylko raz przypisać wartość dla ID
        public int Id { get; init; }
        public string Name { get; set; }
        public int Age { get; set; }

        internal void Deconstruct(out object id, out object name, out object age)
        {
            id = Id;
            name = Name;
            age = Age;
        }
    }
}
