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

        [Theory]
        [InlineData("-v")]
        [InlineData("--v")]
        [InlineData("/v")]
        [InlineData("--version")]
        public void VersionTestValidArgsV2(string indicator)
        {
            var fileProcessor = new Mock<IFileVersionProcessor>();

            var version = fileProcessor.Object.GetVersion(indicator, "C:/test.txt");

            Assert.Matches(@"\bv?[0-9]+\.[0-9]+\.[0-9]+(?:\.[0-9]+)?\b", version);
        }

        [Theory]
        [InlineData("-s")]
        [InlineData("--s")]
        [InlineData("/s")]
        [InlineData("--size")]
        public void SizeTestValidArg(string indicator)
        {
            var fileProcessor = new Mock<IFileSizeProcessor>();

            var size = fileProcessor.Object.GetSize(indicator, "C:/test.txt");

            Assert.IsType(typeof(int), size);
        }

        [Theory]
        [InlineData("s")]
        [InlineData("sa")]
        [InlineData("//s")]
        [InlineData("---size")]
        public void SizeTestInvalidArgs(string indicator)
        {
            var fileProcessor = new Mock<IFileSizeProcessor>();


            Assert.Throws<ArgumentException>(()=>fileProcessor.Object.GetSize(indicator, "C:/test.txt"));
        }
    }
}
