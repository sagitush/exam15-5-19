﻿using System;
using System.Runtime.Serialization;

namespace exam_part_2__question_2
{
    [Serializable]
    internal class ItemAlreadyExistException : Exception
    {
        public ItemAlreadyExistException()
        {
        }

        public ItemAlreadyExistException(string message) : base(message)
        {
        }

        public ItemAlreadyExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ItemAlreadyExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}