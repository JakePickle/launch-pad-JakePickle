﻿namespace LaunchPadJakePickle.Models
{
    class RoverModel
    {
        internal string roverName = string.Empty;
        internal string speedStr = "Speed: " + 0 + " units";
        internal string temperatureStr = "Temperature: " + 0 + " units";
        internal string isConnectedStr = "Connected: " + false;
        internal int speed = 0;
        internal double temperature;
        internal bool isConnected = false;
        internal string roverStatus = string.Empty;
    }
}
