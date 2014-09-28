using LaunchPadJakePickle.Models;
using Caliburn.Micro;

namespace LaunchPadJakePickle.ViewModels
{
    class RoverViewModel : PropertyChangedBase
    {
        private RoverModel Model;      

        public string roverName
        {
            get
            {
                return Model.roverName;
            }
            set
            {
                Model.roverName = value;
                NotifyOfPropertyChange(() => Model.roverName);
            }
        }

        public int speed
        {
            get
            {
                return Model.speed;
            }
            set
            {
                Model.speed = value;
                NotifyOfPropertyChange(() => Model.speed);
            }
        }

        public double temperature
        {
            get
            {
                return Model.temperature;
            }
            set
            {
                Model.temperature = value;
                NotifyOfPropertyChange(() => Model.temperature);
            }
        }

        public bool isConnected
        {
            get
            {
                return Model.isConnected;
            }
            set
            {
                Model.isConnected = value;
                NotifyOfPropertyChange(() => Model.isConnected);
            }
        }

        public RoverViewModel()
        {
            Model = new RoverModel();
        }

        public void Rove()
        {

        }
    }
}
