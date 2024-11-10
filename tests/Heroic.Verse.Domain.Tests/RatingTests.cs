using Heroic.Verse.Domain;
using Heroic.Verse.Domain.Catalog;

namespace Heroic.Verse.Domain.Tests;

[TestClass]
public class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        // Arrange
        var rating = new Rating(1, "Nike", "Great fit!");

        // Act (empty)

        // Assert
        Assert.AreEqual(1, rating.Stars);
        Assert.AreEqual("Nike", rating.UserName);
        Assert.AreEqual("Great fit!", rating.Review);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Rating_With_Invalid_Stars()
    {
        // Arrange
        var rating = new Rating(0, "Nike", "Great fit!");

    }
}