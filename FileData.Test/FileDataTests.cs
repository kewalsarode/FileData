using Moq;
using System;
using Xunit;
using FileData.BL;

namespace FileData.Test
{
    public class FileDataTests
    {
        [Fact]
        public void VersionTestValidArgsV1()
        {
            var fileProcessor = new Mock<IFileVersionProcessor>();

            var version = fileProcessor.Object.GetVersion("-v", "C:/test.txt");

            Assert.Matches("\\d+(\\.\\d+)+", version);
        }
    }
}
