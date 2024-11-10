using Heroic.Verse.Domain;
using Heroic.Verse.Domain.Catalog;

namespace Heroic.Verse.Domain.Tests;

[TestClass]
public class ItemTests
{
    [TestMethod]
    public void Can_Create_New_Item()
    {
        var item = new Item("Name", "Description", "Brand", 10.00m);

        Assert.AreEqual("Name", item.Name);
        Assert.AreEqual("Description", item.Description);
        Assert.AreEqual("Brand",item.Brand);
        Assert.AreEqual(10.00m, item.Price);
    }
}