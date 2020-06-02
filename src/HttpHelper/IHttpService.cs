namespace HttpHelper
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    public interface IHttpService
    {
        Task<HttpResponseMessage> PostAsync(Uri uri, Dictionary<string, string> nameValuCollection);

        Task<HttpResponseMessage> GetAsync(Uri uri);

        CookieContainer CookieContainer { get; }
    }
}
