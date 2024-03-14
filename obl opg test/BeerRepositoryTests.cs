namespace obl_opg_test
{
    [TestClass()]
    public class BeerRepositoryTest
    {
        [TestMethod()]
        public void GetBeersTest()
        {
            var repository = new BeersRepository();
            
            var result = repository.GetBeers();
           
            Assert.AreEqual(5, result.count);
        }
        [TestMethod()]
        public void GetByIdTest()
        {
            var repository = new BeersRepository();
            var expectedBeerId = 1;

            var result = repository.GetById(expectedBeerId);

            Assert.IsNotNull(result);
            Assert.AreEqual(expectedBeerId, result.Id);
        }
        [TestMethod()]
        public void AddBeerTest()
        {
            var repository = new BeersRepository();
            var AddNewBeer = new Beer { Name = "test beer", Abv = 4, 2 };
           
            var result = repository.AddBeer(AddNewBeer);
            var allBeers = repository.GetBeers();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, allBeers.count);
            Assert.IsTrue(allBeers.Any(b=>b.Name=="test beer"));
        }
        [TestMethod()]
        public void RemoveBeerTest() 
        {
            var repository = new BeersRepository();
            var beerIdDelete = 1;

            var result = repository.RemoveBeer(beerIdDelete);
            var allBeers = repository.GetBeers();

            Assert.IsNotNull(result);
            Assert.AreEqual(4, allBeers.count);
            Assert.IsFalse(allBeers.Any(b => b.Id == beerIdDelete));
        
        }
        [TestMethod()]
        public void UpdateBeersTest()
        {
            var repository = new BeersRepository();
            var beerIdUpdate = 1;
            var updateData = new Beer { Name = "updated name", Abv = 33 };

            var result = repository.UpdateBeers(beerIdUpdate, updateData);
            var updatedBeer = repository.GetById(beerIdUpdate);

            Assert.IsNotNull(result);
            Assert.AreEqual("updated name", updatedBeer.Name);
            Assert.AreEqual(6,5,updatedBeer.Abv);
        }


    }
}