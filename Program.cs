using System;
using System.Collections.Generic;
using Yakky;

class TestingCodeSnippets
{
    static void Main(string[] args)
    {
        var description = "The main purpose of this exercise is to write better code that is more clear, highly maintainable and doesnt make your developer friends go crazy.";
        var descriptionForZein = "Maybe Zein can learn a thing or two.";
        var myTest = new SpecialCodeSnippet();
        Console.WriteLine(description);
        Console.WriteLine(descriptionForZein);
        Console.WriteLine(myTest.SendMyEmails(new BrandNewSettings(){}, new List<Email> {new Email()}, false).ToString());
    }
}
