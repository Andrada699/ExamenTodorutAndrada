﻿using System;
namespace Exam.Properties
{
    class Program
    {
        
        internal class StackEmptyException : Exception
        {
            public StackEmptyException()
            {
            }

            public StackEmptyException(string message) : base(message)
            {
            }

            public StackEmptyException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected StackEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }





        }
    }
}
