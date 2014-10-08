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

        public RoverViewModel Rover
        {
            get
            {
                return Model.rover;
            }
            set
            {
                Model.rover = value;
                NotifyOfPropertyChange(() => Model.rover);
            }
        }

        public MainWindowViewModel()
        {
            Model = new MainWindowModel();
            Model.console = new ConsoleViewModel(this);
            Model.rover = new RoverViewModel(this);
        }
    }
}
