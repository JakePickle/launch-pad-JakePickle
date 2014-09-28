using LaunchPadJakePickle.Models;
using Caliburn.Micro;

namespace LaunchPadJakePickle.ViewModels
{
    class RoverViewModel : PropertyChangedBase
    {
        private RoverModel Model;

        public RoverViewModel()
        {
            Model = new RoverModel();
        }

        public void Rove()
        {

        }
    }
}
