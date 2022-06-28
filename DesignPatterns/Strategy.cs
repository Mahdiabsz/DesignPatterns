using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    interface IAsyncRequestStrategy
    {
        AsyncRespone SendRequest(String url);
    }
    class AsyncRespone
    {
        public object Respone { get; set; }
    }

    class XmlHttpRequestApi : IAsyncRequestStrategy
    {
        public AsyncRespone SendRequest(String url)
        {
            AsyncRespone asyncRespone = new AsyncRespone();
            Console.WriteLine("Sent async network request using xhr");
            return asyncRespone;
        }
    }

    class FetchApi : IAsyncRequestStrategy
    {
        public AsyncRespone SendRequest(String url)
        {
            AsyncRespone asyncRespone = new AsyncRespone();
            Console.WriteLine("Sent async network request using Fetch api");
            return asyncRespone;
        }
    }

    enum BrowserType
    {
        IE = 1,
        Chrome = 2
    }

    class WebApplication
    {
        private BrowserType _browserType;
        public WebApplication(BrowserType browserType)
        {
            _browserType = browserType;
        }

        public AsyncRespone SendAsyncRequestToServer(String url)
        {
            IAsyncRequestStrategy asyncRequestStrategy;
            AsyncRespone asyncRespone = null;
            switch (_browserType)
            {
                case BrowserType.IE:
                    asyncRequestStrategy = new XmlHttpRequestApi();
                    return asyncRequestStrategy.SendRequest(url);
                case BrowserType.Chrome:
                    asyncRequestStrategy = new FetchApi();
                    return asyncRequestStrategy.SendRequest(url);
            }
            return asyncRespone;
        }
    }
}
