using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData.BL.Impl
{
    public class FileProcessorPrototype : IFileVersionProcessor
    {
        FileDetails _fileDetails;

        public FileProcessorPrototype(FileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }

        public string GetVersion(string indicator, string filePath)
        {
            if(Constants.PrototypeIndicator.Equals(indicator, StringComparison.InvariantCultureIgnoreCase))
            {
                return _fileDetails.Version(filePath);
            }

            throw new ArgumentException(Constants.InvalidVArgException);
        }
    }
}
