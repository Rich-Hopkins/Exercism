using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HelloWorld
{
	[TestFixture]
    public class HelloWorldTests
    {
	    [Test]
	    public void TestBlank()
	    {
			Assert.That(HelloWorld.Greeting(), Is.EqualTo("Hello World!"));
		}

	    [Test]
	    public void TestRich()
	    {
		    Assert.That(HelloWorld.Greeting("Rich"), Is.EqualTo("Hello Rich!"));
	    }
    }
}
