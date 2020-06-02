namespace HttpHelper
{
    using System;
    using System.Net;

    public class CookieService : ICookieService
    {
        public CookieService()
        {
            this.CookieContainer = new CookieContainer();
        }

        public CookieContainer CookieContainer { get; }

        public void AddCookies(Uri uri)
        {
            this.CookieContainer.Add(uri, new Cookie("name", "value"));
        }
    }
}

