
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class NoQuestionException : Exception
{
        public NoQuestionException()
        {
        }

        public NoQuestionException(string message) : base(message)
        {
        }

        public NoQuestionException(string message, Exception inner)
            : base(message, inner)
        {
        }
}