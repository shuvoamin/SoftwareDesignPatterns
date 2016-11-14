using System;
using System.Diagnostics;

namespace DesignPatterns.FrontControllerPattern
{
    public class FrontController
    {
        private readonly Dispatcher _dispatcher;

        public FrontController()
        {
            _dispatcher = new Dispatcher();
        }

        public Dispatcher Dispatcher
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        private static bool IsAuthenticedUser()
        {
            Trace.WriteLine("User is authenticated successfully." + Environment.NewLine);
            return true;
        }

        private static void TrackRequest(string request)
        {
            Trace.WriteLine("Page requested: " + request + Environment.NewLine);
        }

        public void DispatchRequest(string request)
        {
            //log each request
            TrackRequest(request);

            //authenticate the user
            if (IsAuthenticedUser())
            {
                _dispatcher.Dispatch(request);
            }
        }
    }
}
