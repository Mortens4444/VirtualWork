﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;

namespace VirtualWork.Core.Exceptions
{
	public class ExceptionDetails
	{
		public Exception Exception { get; }

		public string ExceptionType { get; }

		public string[] StackFrameDetials { get; }

		private readonly Exception firstException;

		public ExceptionDetails(Exception ex)
		{
			firstException = ex;
			var stackFrameDetails = new List<string> { StackDetails(ex) };

			while (ex.InnerException != null)
			{
				ex = ex.InnerException;
				var stackDetail = StackDetails(ex);
				if (!String.IsNullOrEmpty(stackDetail))
				{
					stackFrameDetails.Add(stackDetail);
				}
			}
			StackFrameDetials = stackFrameDetails.ToArray();
			Exception = ex;
			ExceptionType = ex.GetType().ToString();
		}

		private static string StackDetails(Exception ex)
		{
			var result = new StringBuilder();
			var stack = new StackTrace(ex, true);

			var frames = stack.GetFrames();
			if (frames != null)
			{
				foreach (var stackFrame in frames)
				{
					// File and line information
					if (stackFrame.GetFileName() != null)
					{
						result.AppendLine($"<{stackFrame.GetFileName()}, Line: {stackFrame.GetFileLineNumber()}>");
					}

					// Method and parameter information
					var method = stackFrame.GetMethod();
					if (method != null)
					{
						if (method.IsConstructor)
						{
							if (method.ReflectedType != null)
							{
								result.Append(method.ReflectedType.FullName);
							}
						}
						else if (method.Name == ".cctor" && method.IsStatic && method.IsSpecialName)
						{
							if (method.ReflectedType != null)
							{
								result.Append(String.Concat("static ", method.ReflectedType.FullName));
							}
						}
						else
						{
							result.Append(method.Name);
						}
						var parameters = String.Join(", ", method.GetParameters().Select(parameter => parameter.ToString()));
						result.Append($"({parameters})");
					}
					result.AppendLine();
				}
			}
			return result.ToString();
		}

		private Exception GetParentException(Exception ex)
		{
			if (ex == firstException)
			{
				return null;
			}
			var result = firstException;
			while (result != null && result.InnerException != ex)
			{
				result = result.InnerException;
			}
			return result;
		}

		public string Messages => GetDetailsToRoot(Exception);

		public string Details => GetDetailsToRoot(Exception, true);

		private string GetDetailsToRoot(Exception ex, bool extraInfo = false)
		{
			var details = new StringBuilder();

			if (extraInfo)
			{
				details.AppendLine(String.Join(Environment.NewLine, StackFrameDetials));
			}

			do
			{
				if (extraInfo)
				{
					details.Append($"{ex.GetType()} - ");
				}
				AppendDetails(details, ex);
				ex = GetParentException(ex);
			}
			while (ex != null);

			return details.ToString();
		}

		private static void AppendDetails(StringBuilder stringBuilder, Exception ex)
		{
			stringBuilder.AppendLine(ex.Message);

			if (ex is Win32Exception win32Exception)
			{
				stringBuilder.AppendLine($"Win32 NativeErrorCode: {win32Exception.NativeErrorCode} - {(SystemErrorCodes)win32Exception.NativeErrorCode}");
			}
			else if (ex is DbEntityValidationException dbEntityValidationException)
			{
				foreach (var entityValidationErrors in dbEntityValidationException.EntityValidationErrors)
				{
					foreach (var validationError in entityValidationErrors.ValidationErrors)
					{
						stringBuilder.AppendLine($"Error message: {validationError.ErrorMessage}, Property name: {validationError.PropertyName}");
					}
				}
			}
#if !__MonoCS__
			else
			{
				if (ex is ManagementException managementException)
				{
					if (managementException.ErrorInformation != null)
					{
						stringBuilder.Append("ErrorInformation description: ");
						stringBuilder.AppendLine(Convert.ToString(managementException.ErrorInformation["Description"]));
					}
				}				
			}
#endif
		}
	}

}
