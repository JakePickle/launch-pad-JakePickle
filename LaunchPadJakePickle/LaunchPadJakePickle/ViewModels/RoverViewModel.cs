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
                Model.roverName = "Rover Name: " + value;
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
                Model.temperatureStr = "Temperature: " + value;
                NotifyOfPropertyChange(() => Model.temperatureStr);
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

        public RoverViewModel(MainWindowViewModel MainWinViewModel)
        {
            MainViewModel = MainWinViewModel;
            Model = new RoverModel();
            roverName = "Rovernamehere";
        }

        public void Rove()
        {
            if (isConnected)
            {
                MainViewModel.Console.Print("Roving Started!");
                Task.Run(async () =>
                {
                    double temperature = 50;
                    int speed = 0;
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
                });
                MainViewModel.Console.Print("Roving Completed!");
            }
            else
            {
                MainViewModel.Console.Print("Roving Failed, Not Connected");
            }
        }
    }
}
