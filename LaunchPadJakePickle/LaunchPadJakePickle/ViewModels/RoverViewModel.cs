﻿using LaunchPadJakePickle.Models;
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

        public RoverViewModel(MainWindowViewModel MainWinViewModel)
        {
            MainViewModel = MainWinViewModel;
            Model = new RoverModel();
            Model.roverName = "something";
        }

        public void Rove()
        {
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
