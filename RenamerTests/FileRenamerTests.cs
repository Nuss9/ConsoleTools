using System;
using Renamer;
using Xunit;

namespace RenamerTests
{
    public class FileRenamerTests
    {
		FileRenamer subject = new FileRenamer();

		[Fact]
		public void WhenInputPathDoesNotExist_ItShouldReturnNull()
		{
			string inputFile = "NonExistingFilePath";

			Assert.Null(subject.Rename(inputFile));
		}
    }
}
