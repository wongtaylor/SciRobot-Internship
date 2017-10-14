﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AudioManager;
using UIKit;
using System.Diagnostics;

namespace test.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.

            UIApplication.Main(args, null, "AppDelegate");

            Initializer.Initialize();

        }
    }
}
