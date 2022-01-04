// Copyright (c) 2021 Matthias Wolf, Mawosoft.

using System;
using System.IO;
using System.Reflection;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Mawosoft.ConsoleApp3.Tests
{
    public class ProgramTests
    {
        private readonly ITestOutputHelper _testOutput;
        public ProgramTests(ITestOutputHelper testOutput) => _testOutput = testOutput;

        [Fact]
        public void Test1()
        {
            StringWriter redirect = new();
            Program.Out = redirect;
            Program.Error = redirect;
            Program.Main(Array.Empty<string>());
            _testOutput.WriteLine(redirect.ToString());
        }

    }
}
