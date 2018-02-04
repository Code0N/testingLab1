﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LakeOfSorrowProduction
{
    public class StringFormatter
    {
        string ShortFileString(string path)
        {
            if (path == String.Empty)
                return path;
            if (path == null)
                throw new NullReferenceException("String is Null");
            return (Path.ChangeExtension(Path.GetFileName(path), ".TMP")).ToUpperInvariant();
        }
    }
}
