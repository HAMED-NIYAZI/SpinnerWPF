﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepApp
{
    // Define the Element abstract class
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
