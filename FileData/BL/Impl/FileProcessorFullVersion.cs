using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData.BL.Impl
{
    public class FileProcessorFullVersion : IFileVersionProcessor, IFileSizeProcessor
    {
        FileDetails _fileDetails;

        public FileProcessorFullVersion(FileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }

        public int GetSize(string indicator, string filePath)
        {
            if(Constants.SizeIndicators.Contains(indicator))
            {
                return _fileDetails.Size(filePath);
            }

            throw new ArgumentException(Constants.InvalidSArgException);
        }

        public string GetVersion(string indicator, string filePath)
        {
            if(Constants.VersionIndicators.Contains(indicator))
            {
                return _fileDetails.Version(filePath);
            }

            throw new ArgumentException(Constants.InvalidVArgException);
        }
    }
}
