using Xunit;

namespace Parrot.Tests
{
    public class ParrotTest
    {
        [Fact]
        public void GetSpeedNorwegianBlueParrot_nailed()
        {
            var parrot = new NorwegianBlueParrot(0, 0, true);
            Assert.Equal(0.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed()
        {
            var parrot = new NorwegianBlueParrot(0, 1.5, false);
            Assert.Equal(18.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed_high_voltage()
        {
            var parrot = new NorwegianBlueParrot(0, 4, false);
            Assert.Equal(24.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_No_Coconuts()
        {
            var parrot = new AfricanParrot(0, 0, false);
            Assert.Equal(12.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_One_Coconut()
        {
            var parrot = new AfricanParrot(1, 0, false);
            Assert.Equal(3.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_Two_Coconuts()
        {
            var parrot = new AfricanParrot(2, 0, false);
            Assert.Equal(0.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfEuropeanParrot()
        {
            var parrot = new EuropeanParrot(0, 0, false);
            Assert.Equal(12.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetCryOfEuropeanParrot()
        {
            var parrot = new EuropeanParrot(0, 0, false);
            Assert.Equal("Sqoork!", parrot.GetCry());
        }

        [Fact]
        public void GetCryOfAfricanParrot()
        {
            var parrot = new AfricanParrot(2, 0, false);
            Assert.Equal("Sqaark!", parrot.GetCry());
        }

        [Fact]
        public void GetCryNorwegianBlueParrot_high_voltage()
        {
            var parrot = new NorwegianBlueParrot(0, 4, false);
            Assert.Equal("Bzzzzzz", parrot.GetCry());
        }

        [Fact]
        public void GetCryNorwegianBlueParrot_no_voltage()
        {
            var parrot = new NorwegianBlueParrot(0, 0, false);
            Assert.Equal("...", parrot.GetCry());
        }
    }
}