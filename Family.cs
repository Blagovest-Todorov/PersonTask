using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members;

        public Family()
        {
            this.Members = new List<Person>();
        }

        public List<Person> Members
        {
            get { return members; }
            set { members = value; }
        }

        public void AddMembers(Person person)
        {
            this.Members.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = this.Members
                .OrderByDescending(p => p.Age)
                .FirstOrDefault();

            return oldestPerson;
        }
    }
}
