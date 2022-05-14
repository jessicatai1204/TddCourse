using System;
using NUnit.Framework;
using TDD;

namespace TDDPractice;

public class BlackBoxTDDTest
{
    private BlackBoxTDD _blackBox;
    [SetUp]
    public void Setup()
    {
        _blackBox = new BlackBoxTDD();
    }

    [Test]
    public void TestEmpty()
    {
        ShouldEqual("", "");
    }
    
    [Test]
    public void TestOne()
    {
        ShouldEqual("A", "A");
    }

    [Test]
    public void TestOneLowCase()
    {
        ShouldEqual("A", "a");
    }
    
    [Test]
    public void TestMulti()
    {
        ShouldEqual("A-Bb", "AB");
    }
    
    [Test]
    public void TestMultiLowerCase()
    {
        ShouldEqual("A-Bb", "Ab");
    }
    
    private void ShouldEqual(string expected, string input)
    {
        Assert.AreEqual(expected, _blackBox.Transfer(input));
    }
}

public class BlackBoxTDD
{
    public string Transfer(string input)
    {
        if(isEmpty(input))
            return "";

        var charArray = input.ToCharArray();
        

        return input.ToUpper();
    }

    private static bool isEmpty(string input)
    {
        return input.Equals(String.Empty);
    }
}