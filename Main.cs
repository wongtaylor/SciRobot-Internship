using System;
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
        static void Main(string[] args)
        {
            UIApplication.Main(args, null, "AppDelegate");

            Initializer.Initialize();

        }
    }
}
