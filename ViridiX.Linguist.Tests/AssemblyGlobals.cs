﻿using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViridiX.Linguist.Network;
using ViridiX.Mason.Logging;

namespace ViridiX.Linguist.Tests
{
    [TestClass]
    public static class AssemblyGlobals
    {
        public static ILogger Logger;

        public static XboxConnectionInformation TestXbox =
            new XboxConnectionInformation(IPAddress.Parse("192.168.1.89"), "abc");

        [AssemblyInitialize]
        public static void Initialize(TestContext testContext)
        {
            Logger = new SeriLogger(LogLevel.Trace);
        }

        [AssemblyCleanup]
        public static void Cleanup()
        {
            Logger?.Dispose();
        }
    }
}
