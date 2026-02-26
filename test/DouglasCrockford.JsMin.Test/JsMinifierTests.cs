using System.IO;
using System.Text;

using NUnit.Framework;

namespace DouglasCrockford.JsMin.Test
{
	[TestFixture]
	public class JsMinifierTests
	{
		const string FilesDirectoryPath = @"Files/";

		private JsMinifier _minifier;


		[OneTimeSetUp]
		public void Init()
		{
			_minifier = new JsMinifier();
		}

		[OneTimeTearDown]
		public void Cleanup()
		{
			_minifier = null;
		}

		[Test]
		public void RegularExpressionLiteralsMinification()
		{
			// Arrange
			const string input1 = @"/^\//";
			const string input2 = @"/^\//.test(a)";

			// Act
			string output1 = _minifier.Minify(input1);
			string output2 = _minifier.Minify(input2);

			// Assert
			Assert.AreEqual(input1, output1);
			Assert.AreEqual(input2, output2);
		}

		[Test]
		public void TheIsLibraryCodeMinification()
		{
			// Arrange
			string input = GetFileContent("is.js", "\r\n");
			string targetOutput = GetFileContent("is.min.js", "\n");

			// Act
			string output = _minifier.Minify(input);

			// Assert
			Assert.AreEqual(targetOutput, output);
		}

		[Test]
		public void TheIsLibraryCodeMinificationWithExternalStringBuilder()
		{
			// Arrange
			var sb = new StringBuilder();

			string input = GetFileContent("is.js", "\r\n");
			string targetOutput = GetFileContent("is.min.js", "\n");

			// Act
			_minifier.Minify(input, sb);

			string output = sb.ToString();
			sb.Clear();

			// Assert
			Assert.AreEqual(targetOutput, output);
		}

		[Test]
		public void DeconstructLibraryCodeMinification()
		{
			// Arrange
			string input = GetFileContent("deconstruct.js", "\r");
			string targetOutput = GetFileContent("deconstruct.min.js", "\n");

			// Act
			string output = _minifier.Minify(input);

			// Assert
			Assert.AreEqual(targetOutput, output);
		}

		private static string GetFileContent(string fileName, string lineFeed)
		{
			string filePath = Path.Combine(FilesDirectoryPath, fileName);
			string[] lines = File.ReadAllLines(filePath);
			string content = string.Join(lineFeed, lines);

			return content;
		}
	}
}