using DesignPatterns.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.FilterPattern
{
    public class OrCriteria :ICriteria
    {
        private ICriteria _criteria;
        private ICriteria _otherCriteria;

        public OrCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = criteria;
        }

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
            List<Person> firstCriteriaItems = _criteria.MeetCriteria(persons);
            List<Person> otherCriteriaItems = _otherCriteria.MeetCriteria(persons);

            foreach (Person person in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }
            return firstCriteriaItems;
        }
    }
}
