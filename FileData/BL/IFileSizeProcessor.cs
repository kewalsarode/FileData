using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.BL
{
    public interface IFileSizeProcessor
    {
        int GetSize(string indicator, string filePath);
    }
}
