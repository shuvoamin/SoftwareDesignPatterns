using DesignPatterns.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.FilterPattern
{
    public class CriteriaMale : ICriteria
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
            var malePersons = new List<Person>();

            foreach (var person in persons)
            {
                if (person.GetGender().Equals("MALE"))
                {
                    malePersons.Add(person);
                }
            }
            return malePersons;
        }
    }
}
