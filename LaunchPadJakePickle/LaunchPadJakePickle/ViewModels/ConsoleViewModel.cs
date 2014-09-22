using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaunchPadJakePickle.Models;
using Caliburn.Micro.PropertyChangedBase;

namespace LaunchPadJakePickle.ViewModels
{
    class ConsoleViewModel
    {
        private ConsoleModel Model;
        private ConsoleViewModel()
        {
            Model = new ConsoleModel();
        }
        
    }
}
