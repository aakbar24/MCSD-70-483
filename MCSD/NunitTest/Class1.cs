using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using chapter_1;

namespace NunitTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void positiveTest()
        {
            int x = 7;
            //test
            int y = 8;
            Program p = new Program();
      
            Assert.AreEqual(1,p.count);
        }
    }
}
