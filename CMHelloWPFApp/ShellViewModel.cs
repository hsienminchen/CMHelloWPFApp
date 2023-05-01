using Caliburn.Micro;

namespace CMHelloWPFApp
{

    public class ShellViewModel : Screen
    {
        private string? _message;

        public string Message
        {
            get { return _message!; }
            set { _message = value; NotifyOfPropertyChange(() => Message); }
        }

        public void SayHello()
        {
            Message = "Hello World!";
        }
    }
}


