namespace DouglasCrockford.JsMin.Tests
{
	using NUnit.Framework;

	using JsMin;

	public class JsMinifierTests
	{
		[Test]
		public void JsMinificationIsCorrect()
		{
			// Arrange
			var minifier = new JsMinifier();

			const string input = "// is.js\r\n" +
				"\r\n" +
				"// (c) 2001 Douglas Crockford\r\n" +
				"// 2001 June 3\r\n" +
				"\r\n\r\n" +
				"// is\r\n" +
				"\r\n" +
				"// The -is- object is used to identify the browser.  Every browser edition\r\n" +
				"// identifies itself, but there is no standard way of doing it, and some of\r\n" +
				"// the identification is deceptive. This is because the authors of web\r\n" +
				"// browsers are liars. For example, Microsoft's IE browsers claim to be\r\n" +
				"// Mozilla 4. Netscape 6 claims to be version 5.\r\n" +
				"\r\n" +
				"// Warning: Do not use this awful, awful code or any other thing like it.\r\n" +
				"// Seriously.\r\n" +
				"\r\n" +
				"var is = {\r\n" +
				"\tie: navigator.appName == 'Microsoft Internet Explorer',\r\n" +
				"\tjava: navigator.javaEnabled(),\r\n" +
				"\tns: navigator.appName == 'Netscape',\r\n" +
				"\tua: navigator.userAgent.toLowerCase(),\r\n" +
				"\tversion: parseFloat(navigator.appVersion.substr(21)) ||\r\n" +
				"             parseFloat(navigator.appVersion),\r\n" +
				"\twin: navigator.platform == 'Win32'\r\n" +
				"}\r\n" +
				"is.mac = is.ua.indexOf('mac') >= 0;\r\n" +
				"\r\n" +
				"if (is.ua.indexOf('opera') >= 0) {\r\n" +
				"\tis.ie = is.ns = false;\r\n" +
				"\tis.opera = true;\r\n" +
				"}\r\n" +
				"\r\n" +
				"if (is.ua.indexOf('gecko') >= 0) {\r\n" +
				"\tis.ie = is.ns = false;\r\n" +
				"\tis.gecko = true;\r\n" +
				"}"
				;
			const string targetOutput = "var is={ie:navigator.appName=='Microsoft Internet Explorer',java:navigator.javaEnabled(),ns:navigator.appName=='Netscape',ua:navigator.userAgent.toLowerCase(),version:parseFloat(navigator.appVersion.substr(21))||parseFloat(navigator.appVersion),win:navigator.platform=='Win32'}\n" +
				"is.mac=is.ua.indexOf('mac')>=0;if(is.ua.indexOf('opera')>=0){is.ie=is.ns=false;is.opera=true;}\n" +
				"if(is.ua.indexOf('gecko')>=0){is.ie=is.ns=false;is.gecko=true;}"
				;

			// Act
			string output = minifier.Minify(input);

			// Assert
			Assert.AreEqual(targetOutput, output);
		}
	}
}