﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    // These attributes are here to allow use C# compiler feature "Caller" info in .NET4 and earlier
    // It won't compile on .NET 4.5 and newer, when using .NET 4.5 and newer, delete this file.

    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class Caller_MemberNameAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class Caller_FilePathAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
    public class Caller_LineNumberAttribute : Attribute
    {
    }

    public static class CompilerHelper
    {
        /// <summary>
        /// Helper method which returns file path of caller.
        /// </summary>
        public static string GetCallerFileName([Caller_FilePath] string filePath = null)
        {
            return filePath;
        }
    }
}
