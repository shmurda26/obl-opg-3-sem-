namespace obl_opg_test
{
    [TestClass()]
    public class BeerTests
    {
        [TestMethod()]
        public void ValidateNameTest()
        {
            Beer beer = new()
            {
                Id = 1,
                Name="beauty",
                Abv = 13
            };
            beer.ValidateName();

            Beer beerNullName = new()
            { 
                Id = 1,
                Name = "",
                Abv = 13
            };
            Assert.ThrowsException<ArgumentException>(() => beerNullName.ValidateName());
         }
        [TestMethod()]
        public void ToStringTest()
        {

        }
        [TestMethod()]
        public void ValidateAbvTest()
        {
            Beer BeerAbvLow = new()
            { Id = 1,
                Name = "beauty",
            Abv = -1
            };
            Assert.ThrowsExeption<ArgumentOutOfRangeException>(
                ()=>BeerAbvLow.ValidateAbv());
            Beer beerInRange = new()
            {
                Id = 1,
                Name = "beauty",
                Abv = 19
            };
            beerInRange.ValidateAbv();
        }
    }
}