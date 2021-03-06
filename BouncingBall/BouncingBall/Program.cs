﻿#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using BouncingBall.Controller;
#endregion

namespace BouncingBall
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (MasterController game = new MasterController())
                game.Run();
        }
    }
#endif
}
