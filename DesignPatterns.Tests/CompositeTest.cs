using DesignPatterns.Composite;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class CompositeTest
    {
        [Test]
        public void ItemAssemblyTest()
        {
            //Given
            Item nut = new Part("Nut", 5);
            Item bolt = new Part("Bolt", 9);
            Item pannel = new Part("Pannel", 35);

            //when
            Item gizmo = new Assembly("Gizmo");
            gizmo.AddItem(pannel);
            gizmo.AddItem(nut);
            gizmo.AddItem(bolt);

            //then
            Assert.AreEqual(49, gizmo.Cost);
        }
    }
}
