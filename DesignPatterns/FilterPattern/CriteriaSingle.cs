﻿using DesignPatterns.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.FilterPattern
{
    public class CriteriaSingle : ICriteria
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
            var singlePersons = new List<Person>();

            foreach (var person in persons)
            {
                if (person.GetMaritalStatus().Equals("SINGLE"))
                {
                    singlePersons.Add(person);
                }
            }
            return singlePersons;
        }
    }
}