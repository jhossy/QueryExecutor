using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTest.Infrastructure.Interfaces
{
    public interface IQueryExecutor
    {
        T Execute<T>(IQuery<T> query); //int execute<int>(IQuery<int> query)
    }
}
