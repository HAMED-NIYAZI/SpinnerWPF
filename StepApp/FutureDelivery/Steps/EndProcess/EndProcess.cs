﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepApp
{
    public class EndProcess : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}