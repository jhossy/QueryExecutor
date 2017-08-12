using QueryTest.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTest.Infrastructure.Model
{
    public class CarQuery : IQuery<List<Car>>
    {
        public List<Car> ExecuteQuery()
        {
            return new List<Car>()
            {
                new Car() { Model = "model1" },
                new Car() { Model = "model2" }
            };
        }
    }
}
