namespace HttpHelper
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class HttpService : IHttpService
    {
        private readonly ICookieService cookieService;

        public HttpService(ICookieService cookieService)
        {
            this.cookieService = cookieService;
        }

        public CookieContainer CookieContainer
            => this.cookieService.CookieContainer;

        public async Task<HttpResponseMessage> PostAsync(
            Uri uri, 
            Dictionary<string, string> nameValuCollection)
        {
            this.cookieService.AddCookies(uri);

            using var handler = new HttpClientHandler
            {
                CookieContainer = this.cookieService.CookieContainer,
            };

            using var client = new HttpClient(handler)
            {
                BaseAddress = uri,
            };

            var content = new FormUrlEncodedContent(nameValuCollection);

            var responseMessage = await client.PostAsync(uri, content);

            return responseMessage;
        }

        public async Task<HttpResponseMessage> GetAsync(Uri uri)
        {
            this.cookieService.AddCookies(uri);

            using var handler = new HttpClientHandler
            {
                CookieContainer = this.cookieService.CookieContainer,
            };

            using var client = new HttpClient(handler)
            {
                BaseAddress = uri,
            };

            var responseMessage = await client.GetAsync(uri);

            return responseMessage;
        }
    }
}
