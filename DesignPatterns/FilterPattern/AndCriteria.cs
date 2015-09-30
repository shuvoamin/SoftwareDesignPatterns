using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            List<Person> firstCriteriaPersons = _criteria.meetCriteria(persons);
            return _otherCriteria.meetCriteria(firstCriteriaPersons);
        }
    }
}
