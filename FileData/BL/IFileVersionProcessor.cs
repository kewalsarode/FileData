using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.BL
{
    public interface IFileVersionProcessor
    {
        string GetVersion(string indicator, string filePath);
    }
}
