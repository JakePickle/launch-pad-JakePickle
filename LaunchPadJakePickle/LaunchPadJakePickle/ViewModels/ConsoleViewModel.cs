using LaunchPadJakePickle.Models;
using Caliburn.Micro;

namespace LaunchPadJakePickle.ViewModels
{
    class ConsoleViewModel : PropertyChangedBase
    {
        private ConsoleModel Model;

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

        public ConsoleViewModel()
        {
            Model = new ConsoleModel();
        }
        
    }
}
