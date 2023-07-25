using System;
using Xunit;
using Block_Beasts_Library;
using Block_Beasts;


namespace BlockBeastTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestPointSystem()
        {
            Trainer TestTrainer = new Trainer("Tester", 0);

            int expectedScore = 1;

            int trainerScore = TestTrainer.AddPoint();

            Assert.Equal(expectedScore, trainerScore);
        }
    }
}