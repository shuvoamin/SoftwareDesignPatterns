using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FilterPattern
{
    public class CriteriaFemale : ICriteria
    {
        public DesignPatterns.Interfaces.ICriteria ICriteria
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        //Override
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();

            foreach (Person person in persons)
            {
                if (person.GetGender().Equals("FEMALE"))
                {
                    femalePersons.Add(person);
                }
            }
            return femalePersons;
        }
    }
}