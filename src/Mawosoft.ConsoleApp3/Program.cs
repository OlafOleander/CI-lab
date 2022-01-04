// Copyright (c) 2021 Matthias Wolf, Mawosoft.

using System;
using System.IO;
using System.Runtime.CompilerServices;

#pragma warning disable CS1591

namespace Mawosoft.ConsoleApp3
{
    internal class Program
    {
        public static TextWriter Out { get; set; } = Console.Out;
        public static TextWriter Error { get; set; } = Console.Error;

        public static void Main(string[] args)
        {
            _ = args;
            Out.WriteLine("WhereAmI: " + WhereAmI());
            Out.WriteLine("CurDir:   " + Directory.GetCurrentDirectory());
        }

        public static string WhereAmI([CallerFilePath]string callerFilePath = "")
        {
            return callerFilePath;
        }
    }
}
