using LaunchPadJakePickle.Models;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace LaunchPadJakePickle.ViewModels
{
    class RoverViewModel : PropertyChangedBase
    {
        private RoverModel Model;
        private MainWindowViewModel MainViewModel;

        public string roverName
        {
            get
            {
                return Model.roverName;
            }
            set
            {
                Model.roverName = "Rover Name: " + value + "\n\n\nRover Status: ";
                NotifyOfPropertyChange(() => Model.roverName);
            }
        }

        public string speedStr
        {
            get
            {
                return Model.speedStr;
            }
            set
            {
                Model.speedStr = "Speed: " + value + " units";
                NotifyOfPropertyChange(() => Model.speedStr);
            }
        }

        public string temperatureStr
        {
            get
            {
                return Model.temperatureStr;
            }
            set
            {
                Model.temperatureStr = "Temperature: " + value + " units";
                NotifyOfPropertyChange(() => Model.temperatureStr);
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
                speedStr = "" + speed;
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
                temperatureStr = "" + temperature;
                NotifyOfPropertyChange(() => Model.temperature);
            }
        }

        public string isConnectedStr
        {
            get
            {
                return Model.isConnectedStr;
            }
            set
            {
                Model.isConnectedStr = "Connected: " + value;
                NotifyOfPropertyChange(() => Model.isConnectedStr);
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
                isConnectedStr = "" + value;
                NotifyOfPropertyChange(() => Model.isConnected);
            }
        }

        public RoverViewModel(MainWindowViewModel MainWinViewModel)
        {
            MainViewModel = MainWinViewModel;
            Model = new RoverModel();
            roverName = "Rovernamehere";
        }

        public void Rove()
        {
            bool isConnected = Model.isConnected;
            if (isConnected)
            {
                MainViewModel.Console.Print("Roving Started!");
                Task.Run(async () =>
                {
                    temperature = 50;
                    for (var i = 0; i < 15; i++)
                    {
                        speed++;
                        temperature += speed / 4;
                        await Task.Delay(200);
                    }
                    for (var i = 14; i >= 0; i--)
                    {
                        temperature -= speed / 4;
                        speed--;
                        await Task.Delay(200);
                    }
                    MainViewModel.Console.Print("Roving Completed!");
                });         
            }
            else
            {
                MainViewModel.Console.Print("Roving Failed, Not Connected");
            }
        }
    }
}
