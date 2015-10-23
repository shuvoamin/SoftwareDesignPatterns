using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPatterns.FilterPattern
{
    public class FilterPatternDemo
    {
        public CriteriaMale CriteriMale
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public CriteriaFemale CriteriaFemale
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public CriteriaSingle CriteriaSingle
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public OrCriteria OrCriteria
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public AndCriteria AndCriteria
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }

        public Person Person
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            var persons = new List<Person>();

            persons.Add(new Person("Robert", "MALE", "SINGLE"));
            persons.Add(new Person("John", "MALE", "MARRIED"));
            persons.Add(new Person("Laura", "FEMALE", "MARRIED"));
            persons.Add(new Person("Diana", "FEMALE", "SINGLE"));
            persons.Add(new Person("Mike", "MALE", "SINGLE"));
            persons.Add(new Person("Bobby", "MALE", "SINGLE"));

            ICriteria male = new CriteriaFemale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Trace.WriteLine("Males: ");
            PrintPersons(male.MeetCriteria(persons));

            Trace.WriteLine("\nFemales: ");
            PrintPersons(female.MeetCriteria(persons));

            Trace.WriteLine("\nSingle Males: ");
            PrintPersons(singleMale.MeetCriteria(persons));

            Trace.WriteLine("\nSingle Or Females: ");
            PrintPersons(singleOrFemale.MeetCriteria(persons));
        }

        private static void PrintPersons(List<Person> persons)
        {
            foreach (var person in persons)
            {
                Trace.WriteLine("Person : [ Name : " + person.GetName() + ", Gender : " + person.GetGender() + ", Marital Status : " + person.GetMaritalStatus() + " ]" + Environment.NewLine);
            }
        }
    }
}
