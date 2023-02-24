using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  // public class ClassNameTests : IDisposable -- use if need to clear out previous results
  // {
  //   public void Dispose()
  //   {
  //     // Code inside this method is run between each test.
  //   }
  {
    // Test methods go here
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBread = new BreadOrder();
      Assert.AreEqual(typeof(BreadOrder), new BreadOrder.GetType());
    }
  }
}

// set up with dotnet restore in ProjectName.Tests directory
// run tests with dotnet test