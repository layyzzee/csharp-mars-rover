using MarsRover.Terminal;
using NUnit.Framework;
using System.Threading.Channels;

namespace MarsRover.Tests;

public class HelloWorldTests
{
    [Test]
    public void Successfully_runs_a_test()
    {
        var input = "Hello World";
        var expected = "Hello World";
        Assert.That(input == expected, Is.True);
    }
}