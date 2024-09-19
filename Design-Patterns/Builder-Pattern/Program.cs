using Builder_Pattern;

class Program
{
    static void Main(string[] args)
    {
        // Generate a URL with all components
        var url1 = new URLBuilder()
            .SetProtocol("https")
            .SetHost("example.com")
            .SetPort("443")
            .SetPath("path/to/resource")
            .SetQuery("key=value")
            .Build();
        Console.WriteLine(url1); // Output: https://example.com:443/path/to/resource?key=value

        // Generate a URL without port and query
        var url2 = new URLBuilder()
            .SetProtocol("http")
            .SetHost("example.org")
            .SetPath("another/path")
            .Build();
        Console.WriteLine(url2); // Output: http://example.org/another/path

        // Generate a URL with only host
        var url3 = new URLBuilder()
            .SetProtocol("ftp")
            .SetHost("ftp.example.net")
            .Build();
        Console.WriteLine(url3); // Output: ftp://ftp.example.net
    }
}