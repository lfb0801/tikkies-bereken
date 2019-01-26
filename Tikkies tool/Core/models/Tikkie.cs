using System;
using System.Collections.Generic;
using System.Text;

namespace core.models
{
    public class Tikkie
    {
        public Person From { get; private set; }
        public Person To { get; private set; }
        public double Amount { get; private set; }
    }
}
