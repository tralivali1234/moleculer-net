﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceAction.Abstractions
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ServiceActionAttribute : Attribute
    {
        private string _name;

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
