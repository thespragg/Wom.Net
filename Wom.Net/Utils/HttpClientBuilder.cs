using System.Net.Http.Json;
using System.Web;
using Wom.Net.Configuration;

namespace Wom.Net.Utils;

public class HttpClientBuilder(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    private readonly List<string> _routes = [];
    private readonly Dictionary<string, object> _queryParameters = new();

    public HttpClientBuilder WithRoute(string route)
    {
        if (!string.IsNullOrWhiteSpace(route))
        {
            _routes.Add(route);
        }

        return this;
    }
    
    public HttpClientBuilder WithQueryParameter(string key, object? value)
    {
        if (!string.IsNullOrWhiteSpace(key) && value != null)
        {
            _queryParameters[key] = value;
        }

        return this;
    }

    public async Task<HttpResponseMessage> ExecuteGetAsync(
        CancellationToken cancellationToken = default
    ) => await _httpClient.GetAsync(BuildUri(), cancellationToken);

    public async Task<HttpResponseMessage> ExecutePostAsync<T>(
        T payload,
        CancellationToken cancellationToken = default
    ) => await _httpClient.PostAsJsonAsync(BuildUri(), payload, JsonOptions.Default, cancellationToken);

    public async Task<HttpResponseMessage> ExecutePostAsync(
        CancellationToken cancellationToken = default
    ) => await _httpClient.PostAsync(BuildUri(), null, cancellationToken);
    
    private string BuildUri()
    {
        var uriBuilder = new UriBuilder(_httpClient.BaseAddress!);
        var path = string.Join("/", _routes);
        uriBuilder.Path = uriBuilder.Path.TrimEnd('/') + "/" + path;

        var query = HttpUtility.ParseQueryString(string.Empty);
        foreach (var kvp in _queryParameters)
        {
            query[kvp.Key] = kvp.Value.ToString();
        }

        uriBuilder.Query = query.ToString();

        return uriBuilder.ToString();
    }
}