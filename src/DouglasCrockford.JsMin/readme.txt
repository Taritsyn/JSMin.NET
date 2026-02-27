

   --------------------------------------------------------------------------------
                         README file for JSMin for .NET v2.2.0

   --------------------------------------------------------------------------------

           Copyright (c) 2013-2026 Andrey Taritsyn - http://www.taritsyn.ru


   ===========
   DESCRIPTION
   ===========
   A .NET port of the Douglas Crockford's JSMin
   (https://github.com/douglascrockford/JSMin).

   =============
   RELEASE NOTES
   =============
   1. JSMin was updated to version of February 25, 2026;
   2. Changed a implementation of the `StringBuilder.TrimStart` extension method;
   3. Performed a migration to the modern C# null/not-null checks;
   4. Added support for .NET 10;
   5. In the `lock` statements for .NET 10 target now uses a instances of the
      `System.Threading.Lock` class;
   6. Added support for nullable reference types.

   =============
   DOCUMENTATION
   =============
   See more information on GitHub - https://github.com/Taritsyn/JSMin.NET