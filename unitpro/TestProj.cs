using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UiLayer;
namespace unitpro
{

   [TestFixture]
    public class TestProj
    {
        [Test]
        public void Test1()
        {
            var r = Program.pass();

            Assert.That("pass", Is.EqualTo("pass"));

        }
    }
}
