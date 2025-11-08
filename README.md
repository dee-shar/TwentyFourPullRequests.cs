# TwentyFourPullRequests.cs
Web-API for [24pullrequests.com](https://24pullrequests.com) which goal is to encourage contribution to open source projects during December. The site suggests open projects, highlights tickets that are good for new contributors, provides guides for contributing and promotes good contributions submitted each day.

## Example
```cs
using TwentyFourPullRequestsApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new TwentyFourPullRequests();
            string meta = await api.GetMeta();
            Console.WriteLine(meta);
        }
    }
}
```
