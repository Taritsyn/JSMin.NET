JSMin for .Net
==============

JSMin.NET is a .NET port of the [Douglas Crockford's JSMin](http://github.com/douglascrockford/JSMin).

## Installation
This library can be installed through NuGet - [http://nuget.org/packages/DouglasCrockford.JsMin](http://nuget.org/packages/DouglasCrockford.JsMin).

## Usage
Consider a simple example of usage of the JSMin.NET:

```csharp
using System;

using DouglasCrockford.JsMin;

namespace TestJsMinDotNet
{
	class Program
	{
		static void Main(string[] args)
		{
			const string code = @"function square(num) {
	return num * num;
}";
			var minifier = new JsMinifier();

			try
			{
				string result = minifier.Minify(code);

				Console.WriteLine("Result of JavaScript minification:");
				Console.WriteLine();
				Console.WriteLine(result);
			}
			catch (JsMinificationException e)
			{
				Console.WriteLine("During minification of JavaScript code an error occurred:");
				Console.WriteLine();
				Console.WriteLine(e.Message);
			}

			Console.ReadLine();
		}
	}
}
```

First we create an instance of the <code title="DouglasCrockford.JsMin.JsMinifier">JsMinifier</code> class.
Then we minify a JavaScript code by using of the `Minify` method and output its result to the console.
In addition, we provide handling of the <code title="DouglasCrockford.JsMin.JsMinificationException">JsMinificationException</code> exception.

## License
[Douglas Crockford's License](https://github.com/Taritsyn/JSMin.NET/blob/master/LICENSE)

## Who's Using JSMin for .Net
If you use the JSMin for .Net in some project, please send me a message so I can include it in this list:

 * [Bundle Transformer](https://github.com/Taritsyn/BundleTransformer) by Andrey Taritsyn
 * [DynamicScriptBundling](https://github.com/rajyraman/DynamicScriptBundling) by Natraj Yegnaraman