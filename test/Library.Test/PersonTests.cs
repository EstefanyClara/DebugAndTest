using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
       
        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
             Person p = new Person("Estefany", "1.234.567-8", 1994);
            string expected= "Estefany"; 
            Assert.AreEqual(expected, p.Name);  //permite verificar la validez del resultado 
        }
        
         [Test]
        public void TestID() // una nueva instancia 
        {
            Person p = new Person("Estefany", "4.653.959-2", 1994);
            string expected= "4.653.959-2"; 
            Assert.AreEqual(expected, p.ID);  //permite verificar la validez del resultado 
        }
        [Test]
        public void TestAnio() // una nueva instancia 
        {
            Person p = new Person("Estefany", "4.653.959-2", 1994);
            int expected= 1994 ; 
            Assert.AreEqual(expected, p.FechaNac);  //permite verificar la validez del resultado 
        }
    }
}