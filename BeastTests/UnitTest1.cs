using Block_Beasts_Library;
namespace BeastTests
{
    public class UnitTest1
    {
        [Fact]
        public void DamageTest()
        {
            Beast HP = new Beast(
                "Test Beast", 25, 25, 3, 1, 3, 3, "This Beast is used for testing");

            int expectedDamage = 3 | 4| 5  ;

            int damageOutputTest = HP.CalcDamage();

            Assert.True(damageOutputTest == 3 || damageOutputTest == 4 || damageOutputTest == 5);
        }
                 
    }
}