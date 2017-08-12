using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTest.Infrastructure.Interfaces
{
    public interface IQuery<out T>
    {
        T ExecuteQuery();
    }
}
