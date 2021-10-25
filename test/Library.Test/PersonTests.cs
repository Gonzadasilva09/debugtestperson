using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestName()
        {
        Person p = new Person("Gonzalo", "2.686.797-9", "02-07-2002");
        string expected = "Gonzalo";
        Assert.AreEqual(expected, p.Name); 
        }

        [Test]
        public void TestID() // Cambiá el nombre para indicar qué estás probando
        {
        Person p = new Person("Gonzalo", "2.686.797-9", "02-07-2002");
        string expected = "2.686.797-9";
        Assert.AreEqual(expected, p.ID);
        }

        public void TestDate() // Cambiá el nombre para indicar qué estás probando
        {
        Person p = new Person("Gonzalo", "2.686.797-9", "02-07-2002");
        string expected = "02-07-2002";
        Assert.AreEqual(expected, p.Fechanac);
        }
    }
}