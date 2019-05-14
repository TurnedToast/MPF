﻿using System;
using DICUI.Data;
using DICUI.Utilities;
using Xunit;

namespace DICUI.Test.Utilities
{
    public class KnownSystemExtensionsTest
    {
        [Fact]
        public void NameTest()
        {
            var values = (KnownSystem[])Enum.GetValues(typeof(KnownSystem));
            foreach(var system in values)
            {
                string expected = Converters.LongName(system);
                string actual = ((KnownSystem?)system).Name();

                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void IsMarkerTest()
        {
            var values = (KnownSystem[])Enum.GetValues(typeof(KnownSystem));
            foreach(var system in values)
            {
                bool expected = system == KnownSystem.MarkerArcadeEnd || system == KnownSystem.MarkerComputerEnd ||
                                system == KnownSystem.MarkerOtherEnd || system == KnownSystem.MarkerDiscBasedConsoleEnd;
                                // || system == KnownSystem.MarkerOtherConsoleEnd;

                bool actual = ((KnownSystem?)system).IsMarker();

                Assert.Equal(expected, actual);
            }
        }

        [Fact]
        public void CategoryNameNotEmptyTest()
        {
            var values = (KnownSystemCategory[])Enum.GetValues(typeof(KnownSystemCategory));
            foreach (var system in values)
            {
                string actual = ((KnownSystem?)system).Name();
                Assert.NotEqual("", actual);
            }
        }
    }
}
