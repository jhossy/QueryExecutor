using QueryTest.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTest.Infrastructure.Model
{
    public class QueryExecutor : IQueryExecutor
    {
        public T Execute<T>(IQuery<T> query)
        {
            return query.ExecuteQuery();
        }
    }
}
