using Easter_Races;

namespace EasterTests;

public class Tests
{
    private DriverRepository driverRepository;

    [SetUp]
    public void SetUp()
    {
        driverRepository = new DriverRepository();
    }

    [Test]
    public void CallingDriverrepositoryConstructorShouldInitializeDriverCollection()
    {
        Assert.NotNull(driverRepository.GetAll());
    }

    [Test]
    public void AddingDriverToDriverRepositoryShouldIncreaseCount()
    {
        Driver driver = new Driver("nameasdfadsf");

        driverRepository.Add(driver);

        Assert.AreEqual(1, driverRepository.GetAll().Count);
        foreach(Driver innerDriver in driverRepository.GetAll())
        {
            Assert.AreEqual(driver.Name, innerDriver.Name);
        }
    }

    [Test]
    public void GivenMissingDriverWhenGetByNameThanReturnNull()
    {
        Driver driver = driverRepository.GetByName("asdasd");

        Assert.IsNull(driver);
    }

    [Test]
    public void GivenExistingDriverWhenGetByNameThanReturnDriver()
    {
        Driver driver = new Driver("asdasd");
        driverRepository.Add(driver);

        Driver resultDriver = driverRepository.GetByName("asdasd");

        Assert.AreEqual(driver.Name, resultDriver.Name);
    }

    [Test]
    public void GivenExistingDriversWhenRemoveThanDriversShouldDecrease()
    {
        Driver driver = new Driver("asdasd");
        driverRepository.Add(driver);

        Assert.AreEqual(1, driverRepository.GetAll().Count);

        driverRepository.Remove(driver);

        Assert.AreEqual(0, driverRepository.GetAll().Count);
    }
}