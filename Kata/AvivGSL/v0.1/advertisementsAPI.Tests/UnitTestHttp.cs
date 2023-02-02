namespace advertisementsAPI.Tests;
/*
<summary>
This class tests the API routes.
</summary>
*/
public class UnitTestHttp
{
    private HttpClient? _httpClient;
    /*
    <summary>
    This test is the case when the minimalAPI isn't up.
    </summary>
    */
    [Fact]
    public async Task TestLandingPage_404()
    {
        //Arrange
        var handlerMock = new Mock<HttpMessageHandler>();
        var response = new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.NotFound
        };
        handlerMock.Protected()
        .Setup<Task<HttpResponseMessage>>
        (
            "SendAsync",
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>()
        ).ReturnsAsync(response);
        _httpClient = new HttpClient(handlerMock.Object);
        //Act
        //The client sends the request and receives the response.
        using HttpResponseMessage resp = await _httpClient.GetAsync("http://localhost:5052/annonce");
        //Assert
        //The actual response is a pass or fail compared to an expected response.
        Assert.Equal(HttpStatusCode.NotFound, resp.StatusCode);
    }
    /*
    <summary>
    This test is the test when the minimalAPI is running.
    </summary>
    */
    [Fact]
    public async void TestLandingPage_200()
    {
        //Arrange
        var handlerMock = new Mock<HttpMessageHandler>();
        var response = new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.Found
        };
        handlerMock.Protected()
        .Setup<Task<HttpResponseMessage>>
        (
            "SendAsync",
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>()
        ).ReturnsAsync(response);
        _httpClient = new HttpClient(handlerMock.Object);
        //Act
        //The client sends the request and receives the response.
        using HttpResponseMessage resp = await _httpClient.GetAsync("http://localhost:5052/");
        //Assert
        //The actual response is a pass or fail compared to an expected response.
        Assert.Equal(HttpStatusCode.Found, resp.StatusCode);
    }
    /*
    <summary>
    The test is the case when the advertisement searched for display isn't in the database.
    </summary>
    */
    [Fact]
    public async Task TestAdvertisementPage_404()
    {
        //Arrange
        var handlerMock = new Mock<HttpMessageHandler>();
        var response = new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.NotFound
        };
        handlerMock.Protected()
        .Setup<Task<HttpResponseMessage>>
        (
            "SendAsync",
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>()
        ).ReturnsAsync(response);
        _httpClient = new HttpClient(handlerMock.Object);
        //Act
        //The client sends the request and receives the response.
        using HttpResponseMessage resp = await _httpClient.GetAsync("http://localhost:5052/annonce/1");
        //Assert
        //The actual response is a pass or fail compared to an expected response.
        Assert.Equal(HttpStatusCode.NotFound, resp.StatusCode);
    }
    /*
    <summary>
    The test is the case when the advertisement searched for display is in the database.
    </summary>
    */
    [Fact]
    public async void TestAdvertisementPage_200()
    {
        //Arrange
        var handlerMock = new Mock<HttpMessageHandler>();
        var response = new HttpResponseMessage
        {
            StatusCode = HttpStatusCode.Found
        };
        handlerMock.Protected()
        .Setup<Task<HttpResponseMessage>>
        (
            "SendAsync",
            ItExpr.IsAny<HttpRequestMessage>(),
            ItExpr.IsAny<CancellationToken>()
        ).ReturnsAsync(response);
        _httpClient = new HttpClient(handlerMock.Object);
        //Act
        //The client sends the request and receives the response.
        using HttpResponseMessage resp = await _httpClient.GetAsync("http://localhost:5052/annonce/1");
        //Assert
        //The actual response is a pass or fail compared to an expected response.
        Assert.Equal(HttpStatusCode.Found, resp.StatusCode);
    }
}