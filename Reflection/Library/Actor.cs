using System;
using Interface;

namespace Library
{
    public class Actor : IPerson
    {
        public string firstname;
        private string surname;

        public string Name { get { return  firstname + surname; } }

        public Actor(string aName, string aSurname) {
            firstname = aName;
            surname = aSurname;
        }

        public string SayHello(string to) {
            return "Hellooo! " + to;
        }
    }
}
