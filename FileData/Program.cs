using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using FileData.BL;
using FileData.BL.Impl;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IFileVersionProcessor fileProcessor = new FileProcessorPrototype(new FileDetails());
            Console.WriteLine(fileProcessor.GetVersion(args[0], args[1]));
        }
    }
}
