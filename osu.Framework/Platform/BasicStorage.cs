﻿using System;
using System.IO;
using SQLite;

namespace osu.Framework.Platform
{
    public abstract class BasicStorage
    {
        public string BaseName { get; set; }
    
        public BasicStorage(string baseName)
        {
            BaseName = baseName;
        }

        public abstract Stream GetStream(string path, FileAccess mode = FileAccess.Read);
        public abstract SQLiteConnection GetDatabase(string name);
    }
}