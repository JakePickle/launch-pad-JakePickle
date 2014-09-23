using LaunchPadJakePickle.Models;
using Caliburn.Micro;

namespace LaunchPadJakePickle.ViewModels
{

    class MainWindowViewModel : PropertyChangedBase
    {
        private MainWindowModel Model;

        public ConsoleViewModel Console
        {
            get
            {
                return Model.console;
            }
            set
            {
                Model.console = value;
                NotifyOfPropertyChange(() => Model.console);
            }
        }

        public MainWindowViewModel()
        {
            Model = new MainWindowModel();
            Model.console = new ConsoleViewModel();
        }
    }
}
