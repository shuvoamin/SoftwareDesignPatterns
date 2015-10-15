using System;

namespace DesignPatterns.FrontControllerPattern
{
    public class Dispatcher
    {
        private StudentView _studentView;
        private HomeView _homeView;

        public Dispatcher()
        {
            _studentView = new StudentView();
            _homeView = new HomeView();
        }

        public HomeView HomeView
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public StudentView StudentView
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Dispatch(String request)
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
