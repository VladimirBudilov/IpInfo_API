namespace IT_CORN_WEB_API.Controller;

public class IpInfoService
{
    private readonly HttpClient _client;
    private readonly string _url = "https://ipinfo.io/";

    public IpInfoService(HttpClient client)
    {
        _client = client;
    }

    public async Task<string> GetIpInfo(string ip)
    {
        var response = await _client.GetAsync($"{_url}{ip}/geo");
        var content = await response.Content.ReadAsStringAsync();
        return content;
    }
}