using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode Prev { get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode(int value)
        {
            Value = value;
            Next = null;
            Prev = null;
        }
    }
}

