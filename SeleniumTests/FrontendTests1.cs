using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class FrontendTests1
    {
        [TestCaseOrderer("ViruVarvid_Testing.PriorityOrderer", "ViruVarvid.Testing")]
        public class FrontendTest1
        {
            [Fact, Order(1)]
            public void test()
            {

            }
        }
    }
}
