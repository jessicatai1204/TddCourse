using NUnit.Framework;
using TDD;

namespace TDDPractice;

public class BlackBoxText
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestEmpty()
    {
        var transfer = new BlackBox().Transfer("");
        Assert.AreEqual(transfer, "");
    }
    
    [Test]
    public void TestOneLower()
    {
        var transfer = new BlackBox().Transfer("a");
        Assert.AreEqual(transfer, "A");
    }
    
    [Test]
    public void TestMultiLow()
    {
        var transfer = new BlackBox().Transfer("abc");
        Assert.AreEqual(transfer, "A-Bb-Ccc");
    }
    
    [Test]
    public void TestOneUpper()
    {
        var transfer = new BlackBox().Transfer("A");
        Assert.AreEqual(transfer, "A");
    }
    
    [Test]
    public void TestMultiUpper()
    {
        var transfer = new BlackBox().Transfer("ABC");
        Assert.AreEqual(transfer, "A-Bb-Ccc");
    }
    
    [Test]
    public void TestMultiSpecial()
    {
        var transfer = new BlackBox().Transfer(" +=");
        Assert.AreEqual(transfer, " -++-===");
    }
    
}