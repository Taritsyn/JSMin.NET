﻿namespace DouglasCrockford.JsMin
{
	using System;

	/// <summary>
	/// The exception that is thrown when a minification of asset code by JSMin is failed
	/// </summary>
	public sealed class JsMinificationException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the DouglasCrockford.JsMin.JsMinificationException
		/// class with a specified error message
		/// </summary>
		/// <param name="message">The message that describes the error</param>
		public JsMinificationException(string message)
			: base(message)
		{ }

		/// <summary>
		/// Initializes a new instance of the DouglasCrockford.JsMin.JsMinificationException
		/// class with a specified error message and a reference to the inner exception that is the cause of 
		/// this exception
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception</param>
		/// <param name="innerException">The exception that is the cause of the current exception</param>
		public JsMinificationException(string message, Exception innerException)
			: base(message, innerException)
		{ }
	}
}