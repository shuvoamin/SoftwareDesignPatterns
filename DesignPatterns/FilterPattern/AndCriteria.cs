using DesignPatterns.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.FilterPattern
{
    public class AndCriteria : ICriteria
    {
        private ICriteria _criteria;
        private ICriteria _otherCriteria;

        public AndCriteria(ICriteria criteria, ICriteria otherCriteria)
        {
            _criteria = criteria;
            _otherCriteria = otherCriteria;
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
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = _criteria.meetCriteria(persons);
            return _otherCriteria.meetCriteria(firstCriteriaPersons);
        }
    }
}
