using DesignPatterns.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.FilterPattern
{
    public class CriteriaFemale : ICriteria
    {
        public ICriteria ICriteria
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
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var femalePersons = new List<Person>();

            foreach (var person in persons)
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