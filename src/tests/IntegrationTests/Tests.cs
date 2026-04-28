namespace EachLabs.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static EachLabsClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("EACHLABS_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("EACHLABS_API_KEY environment variable is not found.");

        var client = new EachLabsClient(apiKey);
        
        return client;
    }
}
