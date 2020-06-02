namespace HttpHelper
{
    using System;
    using System.Net;

    public interface ICookieService
    {
        CookieContainer CookieContainer { get; }

        void AddCookies(Uri uri);
    }
}
