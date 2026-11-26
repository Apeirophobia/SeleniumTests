using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace SeleniumTests
{
    public class PriorityOrderer : ITestCaseOrderer
    {
        // meetod võtab sisse kõiki testid
        public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases) where TTestCase : ITestCase
        {
            // ja tagastab nad järjestikuna arendaja defineeritud järjesti järgi
            return testCases.OrderBy(test =>
            {
                // leitakse omadus
                var method = test.TestMethod.Method.GetCustomAttributes(typeof(OrderAttribute)).FirstOrDefault();
                // kui ei leita
                if (method == null)
                {
                    // antakse testile suurim võimalik täisarv
                    return int.MaxValue;
                }
                else
                {

                    // vastasel juhul tagastatakse omaduse order väärtus
                    return method.GetNamedArgument<int>(nameof(OrderAttribute.Value));
                }

            }
            ).ToList(); // tekitatakse loend sorteeritud testideks
        }
    }
}
