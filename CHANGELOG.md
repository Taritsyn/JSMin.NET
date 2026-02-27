Change log
==========

## v2.2.0 - February 27, 2026
 * JSMin was updated to version of February 25, 2026
 * Changed a implementation of the `StringBuilder.TrimStart` extension method
 * Performed a migration to the modern C# null/not-null checks
 * Added support for .NET 10
 * In the `lock` statements for .NET 10 target now uses a instances of the `System.Threading.Lock` class
 * Added support for nullable reference types

## v2.1.0 - October 31, 2019
 * JSMin was updated to version of October 30, 2019
 * The `GetEstimatedOutputLength` method is deprecated. Use a length of input string or any other suitable value instead
 * Enabled a SourceLink in NuGet package

## v2.0.0 - April 3, 2019
 * Added an overloaded version of the `Minify` method that takes a instance of string builder. This will allow to integrate minifier with the external string builder pools
 * Added a `GetEstimatedOutputLength` static method that can be used to calculate the capacity of string builder
 * Added support of .NET Framework 4.5 and .NET Standard 2.0

## v1.1.3 - March 25, 2017
 * Added support of .NET Core 1.0.4
 * Downgraded .NET Standard version from 1.1 to 1.0

## v1.1.2 - January 5, 2017
 * Added support of .NET Core 1.0.3
 * `JsMinificationException` class was made serializable

## v1.1.1 - July 19, 2016
 * Optimized memory usage

## v1.1.0 - June 30, 2016
 * Added support of .NET Core 1.0 RTM

## v1.1.0 RC 2 - May 20, 2016
 * Added support of .NET Core 1.0 RC 2

## v1.1.0 RC 1 - March 26, 2016
 * Added support of .NET Core 5 RC 1

## v1.0.1 - March 25, 2016
 * Assembly is now targeted on the .NET Framework 4 Client Profile
 * “JSMin.NET” NuGet package renamed to “DouglasCrockford.JsMin”

## v1.0.0 - September 16, 2013
 * Initial version uploaded