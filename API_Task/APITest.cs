using NUnit.Framework;
using RestSharp;

[TestFixture]
public class ApiTests
{
    private RestClient _client;

    [SetUp]
    public void Setup()
    {
        _client = new RestClient("https://simple-books-api.glitch.me");
    }

    [Test]
    public void GetBookDetails_Returns200StatusCode()
    {
        var request = new RestRequest("/books", Method.GET);
        var response = _client.Execute(request);

        Assert.AreEqual(200, (int)response.StatusCode);
    }

    [Test]
    public void GetBookDetails_ContainsIDAndName()
    {
        var request = new RestRequest("/books", Method.GET);
        var response = _client.Execute(request);

        var book = response.Content;

        Assert.IsTrue(book.Contains("id"));
        Assert.IsTrue(book.Contains("name"));
    }
}