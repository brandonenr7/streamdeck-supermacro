﻿using BarRaider.SdTools;
using CommandLine;
using System;
using System.Collections.Generic;

namespace SuperMacro
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Uncomment this line of code to allow for debugging
            //while (!System.Diagnostics.Debugger.IsAttached) { System.Threading.Thread.Sleep(100); }

            SDWrapper.Run(args);
        }
    }
}
