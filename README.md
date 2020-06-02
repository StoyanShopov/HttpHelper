# HttpHelper
HttpHelper is simplified to send easily GET and POST request.

## Examples

```csharp
private static async Task GetAsyncExample()
{
    var cookieService = new CookieService();
    var httpService = new HttpSerivce(cookieService);

    const string targetUri = "https://github.com/StoyanShopov";
    Uri uri = new Uri(targetUri);

    var result = await httpService.GetAsync(uri);

    var byteResult = await result.Content.ReadAsByteArrayAsync();
    var stringResult = await result.Content.ReadAsStringAsync();

    //...
}

private static async Task PostAsyncExample()
{
    var cookieService = new CookieService();
    var httpService = new HttpSerivce(cookieService);

    const string targetUri = "https://github.com/StoyanShopov";
    Uri uri = new Uri(targetUri);

    var keyValuePairCollection = new Dictionary<string, string>
    {
        { "Id", "1" },
        { "__RequestVerificationToken", "value" },
    };

    var result = await httpService.PostAsync(uri, keyValuePairCollection);

    var byteResult = await result.Content.ReadAsByteArrayAsync();
    var stringResult = await result.Content.ReadAsStringAsync();

    //...
}
```
