﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class queue
    {
        private int[] buffer;
        private int top;

        public queue()
        {
            this.buffer = new int[10];
            this.top = 0;
        }
        public void Enqueue(int n)
        {
            buffer[top-1] = n;
        }
        public int Dequeue()
        {
            int n = buffer[0];
            for (int i = 0; i < top; i++)
                buffer[i] = buffer[i + 1];
            top--;
                return n;
        }
        public int peek()
        {
            return buffer[0];
        }
        public int count()
        {

            return top + 1;
        }
        public void clear()
        {
            top = -1;
        }
    }
}
