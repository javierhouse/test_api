namespace unit_test_api;


public class UnitTest1
{
    private readonly ILogger<WeatherForecastController> _logger;

    public UnitTest1()
    {
        _logger = A.Fake<ILogger<WeatherForecastController>>();
    }
    
    [Fact]
    public void Test_Ends_Ko()
    {
        //Arrange
        var WeatherForecast = A.Fake<ICollection<WeatherForecast>>();
        WeatherForecastController controller = new WeatherForecastController(_logger);
        
        //Act
        var result = controller.Get();
        
        //Assert
        result.Should().NotBeNull();        
    }

/*
    [Fact]
    public void Test_Ends_Ok()
    {
        WeatherForecastController controller = new WeatherForecastController(_logger);
        ObjectResult responseController = (ObjectResult)controller.GetPrueba (200);
        Assert.Equal((int)HttpStatusCode.OK,responseController.StatusCode!.Value);
    }
    */
}