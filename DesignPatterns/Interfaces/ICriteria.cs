using DesignPatterns.FilterPattern;
using System.Collections.Generic;

namespace DesignPatterns.Interfaces
{
    public interface ICriteria
    {
        List<Person> meetCriteria(List<Person> persons);
    }
}
