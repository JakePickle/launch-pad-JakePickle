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

        public ConsoleViewModel(MainWindowViewModel MainWinViewModel)
        {
            MainViewModel = MainWinViewModel;
            Model = new ConsoleModel();
            Text = "some arbitrary text.";
        }

        public void Clear()
        {
            Text = string.Empty;
        }

        public void Connect()
        {
            Text += "Connected!" + System.Environment.NewLine;
        }

        public void Disconnect()
        {
            Text += "Disconnected!" + System.Environment.NewLine;
        }
        
    }
}
