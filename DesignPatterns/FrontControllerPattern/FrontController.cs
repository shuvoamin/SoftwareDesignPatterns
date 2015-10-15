using System;

namespace DesignPatterns.FrontControllerPattern
{
    public class FrontController
    {
        private Dispatcher _dispatcher;

        public FrontController()
        {
            _dispatcher = new Dispatcher();
        }

        public Dispatcher Dispatcher
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private Boolean IsAuthenticedUser()
        {
            Console.WriteLine("User is authenticated successfully." + Environment.NewLine);
            return true;
        }

        private void TrackRequest(String request)
        {
            Console.WriteLine("Page requested: " + request + Environment.NewLine);
        }

        public void DispatchRequest(String request)
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
