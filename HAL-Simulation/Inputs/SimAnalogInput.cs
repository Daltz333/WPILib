﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAL_Simulator.Inputs
{
    public class SimAnalogInput : IServoFeedback
    {
        private Dictionary<dynamic, dynamic> dictionary = null;
         
        public SimAnalogInput(int pin)
        {
            dictionary = SimData.halData["analog_in"][pin];
        }

        //Volts
        public void Set(double value)
        {
            dictionary["voltage"] = (float)value;
            dictionary["avg_voltage"] = (float)value;
        }
    }
}