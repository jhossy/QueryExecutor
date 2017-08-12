using QueryTest.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTest.Infrastructure.Model
{
    public class IntQuery : IQuery<int>
    {
        public int ExecuteQuery()
        {
            return 1;
        }
    }
}
