using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPadJakePickle.Models;
using Caliburn.Micro.PropertyChangedBase;

namespace LaunchPadJakePickle.ViewModels
{

    class MainWindowViewModel
    {
        private MainWindowModel Model;
        public MainWindowViewModel()
        {
            Model = new MainWindowModel();
        }
    }
}
