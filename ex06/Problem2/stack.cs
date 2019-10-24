using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    public class stack
    {
        private int[] buffer;
        private int top;
        
        public stack()
        {
            this.top = -1;
            this.buffer = new int[10];
        }
        public void push(int n)
        {
            buffer[++top] = n;
        }
        public int pop()
        {
            int n=buffer[top];
            top--;
            return n;
        }
        public int peek()
        {
            return buffer[top];
        }
        public int count()
        {
            
            return top+1;
        }
        public void clear()
        {
            top = -1;
        }
    }
}
