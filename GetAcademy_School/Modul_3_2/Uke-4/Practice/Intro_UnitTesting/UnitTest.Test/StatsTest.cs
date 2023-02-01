
using UnitTesting.ConsoleApp;

namespace UnitTest.Test
{
    public class StatsTest
    {
        [Test]
        public void TestWith3And4()
        {
            // arange
            var stats = new Stats();

            // act
            stats.Add(3);
            stats.Add(4);

            // assert
            Assert.AreEqual(2, stats.Count);
            Assert.AreEqual(7, stats.Sum);
            Assert.AreEqual(4, stats.Max);
            Assert.AreEqual(3, stats.Min);
            Assert.AreEqual(3.5, stats.Mean);

            //Double delta : feil margin
        }

        //Ny test: hvis man sender in ingeting, se verdiene forblir "null"
        //stats.Add() er kommentert bort


        [Test]
        public void TestWithNull()
        {
            // Test ved å ikke sende inn no,verdien skal bli null

            // arange
            var stats = new Stats();

           
            // assert
            //Assert.IsNull(stats.Max);
            //Assert.IsNull(stats.Min);

        }
    }
}