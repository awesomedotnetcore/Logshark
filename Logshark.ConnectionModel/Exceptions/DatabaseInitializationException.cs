﻿using System;

namespace Logshark.ConnectionModel.Exceptions
{
    [Serializable]
    public class DatabaseInitializationException : Exception
    {
        public DatabaseInitializationException()
        {
        }

        public DatabaseInitializationException(string message)
            : base(message)
        {
        }

        public DatabaseInitializationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}