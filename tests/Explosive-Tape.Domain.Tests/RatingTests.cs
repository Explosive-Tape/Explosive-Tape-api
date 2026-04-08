using Microsoft.VisualStudio.TestTools.UnitTesting;
using Explosive_Tape.Domain.Catalog;
using System;
namespace Explosive_Tape.Domain.Tests;

[TestClass]
public class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        // Arrange
        var rating = new Rating(1, "Mike", "Great fit!");

        // Act (empty)

        // Assert
        Assert.AreEqual(1, rating.Stars);
        Assert.AreEqual("Mike", rating.UserName);
        Assert.AreEqual("Great fit!", rating.Review);
    }
    [TestMethod]
    public void Cannot_Create_Rating_With_Stars_Less_Than_1()
    {
        try
        {
            var rating = new Rating(0, "Mike", "Bad rating");
            Assert.Fail("Expected ArgumentException was not thrown.");
        }
        catch (ArgumentException)
        {
            // expected
        }
    }
}
