using System;
using System.Runtime.Serialization;

namespace exam_part_2__question_2
{
    [Serializable]
    internal class MyIndexOutOfRangeException : Exception
    {
        public MyIndexOutOfRangeException()
        {
        }

        public MyIndexOutOfRangeException(string message) : base(message)
        {
        }

        public MyIndexOutOfRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyIndexOutOfRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}