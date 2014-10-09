using LaunchPadJakePickle.Models;
using Caliburn.Micro;

namespace LaunchPadJakePickle.ViewModels
{
    class ConsoleViewModel : PropertyChangedBase
    {
        private ConsoleModel Model;
        private MainWindowViewModel MainViewModel;

        public string Text
        {
            get
            {
                return Model.text;
            }
            set
            {
                Model.text = value;
                NotifyOfPropertyChange(() => Model.text);
            }
        }

        public string roverNameConsole
        {
            get
            {
                return MainViewModel.Rover.roverName+"\nConsole";
            }
            set
            {
                Model.roverNameConsole = MainViewModel.Rover.roverName+"\nConsole";
                NotifyOfPropertyChange(() => Model.roverNameConsole);
            }
        }

        public ConsoleViewModel(MainWindowViewModel MainWinViewModel)
        {
            MainViewModel = MainWinViewModel;
            Model = new ConsoleModel();
            Print("Rover Output Console");
        }

        public void Clear()
        {
            Text = "Rover Output Console" + System.Environment.NewLine;
        }

        public void Connect()
        {
            MainViewModel.Rover.isConnected = true;
            Print("Connected!");
        }

        public void Disconnect()
        {
            MainViewModel.Rover.isConnected = false;
            Print("Disconnected!");
        }

        public void Print(string str)
        {
            Text += str + System.Environment.NewLine;
            return;
        }
        
    }
}
