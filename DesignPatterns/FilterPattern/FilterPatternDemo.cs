using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns.FilterPattern
{
    public class FilterPatternDemo
    {
        public CriteriaMale CriteriMale
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public CriteriaFemale CriteriaFemale
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public CriteriaSingle CriteriaSingle
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public OrCriteria OrCriteria
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public AndCriteria AndCriteria
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Person Person
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output()
        {
            List<Person> persons = new List<Person>();

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

            Console.WriteLine("Males: ");
            PrintPersons(male.meetCriteria(persons));

            Console.WriteLine("\nFemales: ");
            PrintPersons(female.meetCriteria(persons));

            Console.WriteLine("\nSingle Males: ");
            PrintPersons(singleMale.meetCriteria(persons));

            Console.WriteLine("\nSingle Or Females: ");
            PrintPersons(singleOrFemale.meetCriteria(persons));
        }

        private static void PrintPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.GetName() + ", Gender : " + person.GetGender() + ", Marital Status : " + person.GetMaritalStatus() + " ]" + Environment.NewLine);
            }
        }
    }
}
