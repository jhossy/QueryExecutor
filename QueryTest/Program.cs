using QueryTest.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryExecutor queryExecutioner = new QueryExecutor();

            IntQuery intQuery = new IntQuery();
            StringQuery strQuery = new StringQuery();
            CarQuery carQuery = new CarQuery();

            Console.WriteLine(queryExecutioner.Execute(intQuery));
            Console.WriteLine(queryExecutioner.Execute(strQuery));
            Console.WriteLine(queryExecutioner.Execute(carQuery));

            Console.ReadLine();
        }
    }
}
