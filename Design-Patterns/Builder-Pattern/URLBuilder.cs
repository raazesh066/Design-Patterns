namespace Builder_Pattern;

public class URLBuilder
{
    private string protocol;
    private string host;
    private string port;
    private string path;
    private string query;

    public URLBuilder SetProtocol(string protocol)
    {
        this.protocol = protocol;
        return this;
    }

    public URLBuilder SetHost(string host)
    {
        this.host = host;
        return this;
    }

    public URLBuilder SetPort(string port)
    {
        this.port = port;
        return this;
    }

    public URLBuilder SetPath(string path)
    {
        this.path = path;
        return this;
    }

    public URLBuilder SetQuery(string query)
    {
        this.query = query;
        return this;
    }

    public string Build()
    {
        var url = $"{protocol}://{host}";

        if (!string.IsNullOrEmpty(port))
        {
            url += $":{port}";
        }

        if (!string.IsNullOrEmpty(path))
        {
            url += $"/{path}";
        }

        if (!string.IsNullOrEmpty(query))
        {
            url += $"?{query}";
        }

        return url;
    }
}
