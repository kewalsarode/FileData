using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
    public class Constants
    {
        public static string PrototypeIndicator = "-v";
        public static string InvalidVArgException = "Invalid version indicator arguments";
        public static string InvalidSArgException = "Invalid size indicator arguments";
        public static string[] VersionIndicators = { "-v", "--v", "/v", "--version" };
        public static string[] SizeIndicators = {"-s", "--s", "/s", "--size"};
    }
}
