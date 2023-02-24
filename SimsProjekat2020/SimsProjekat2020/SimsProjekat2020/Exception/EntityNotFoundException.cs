﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassDiagramGroup19.Exception
{
    class EntityNotFoundException
    {
        public EntityNotFoundException()
        {

        }

        public EntityNotFoundException(string message) : base(message)
        {

        }

        public EntityNotFoundException(string message, System.Exception inner) : base(message, inner)
        {

        }
    }
}
