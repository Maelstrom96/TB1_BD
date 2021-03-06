﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest
{
    class PlayerNotFoundException : Exception
    {
        public PlayerNotFoundException()
        {
        }

        public PlayerNotFoundException(string message) : base(message)
        {
        }

        public PlayerNotFoundException(string message, Exception inner): base(message, inner)
        {
        }
    }
}
