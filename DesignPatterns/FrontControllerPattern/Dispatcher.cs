using System;

namespace DesignPatterns.FrontControllerPattern
{
    public class Dispatcher
    {
        private readonly StudentView _studentView;
        private readonly HomeView _homeView;

        public Dispatcher()
        {
            _studentView = new StudentView();
            _homeView = new HomeView();
        }

        public HomeView HomeView
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public StudentView StudentView
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Dispatch(string request)
        {
            if (request.Equals("STUDENT"))
            {
                _studentView.Show();
            }
            else
            {
                _homeView.Show();
            }
        }
    }
}
