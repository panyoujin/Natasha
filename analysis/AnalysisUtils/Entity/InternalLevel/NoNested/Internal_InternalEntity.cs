﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnalysisUtils
{
    internal class Internal_InternalEntity
    {
        public Internal_InternalEntity()
        {
            Field = "1";
            Property = "1";
            StaticField = "1";
            StaticProperty = "1";
            ReadOnlyField = "1";
        }

        public string GetFiled()
        {
            return Field;
        }
        internal string Field;
        internal string Property { get; set; }

        internal static string StaticField;
        internal static string StaticProperty { get; set; }

        internal const string ConstField = "1";

        internal readonly string ReadOnlyField;
    }
}
