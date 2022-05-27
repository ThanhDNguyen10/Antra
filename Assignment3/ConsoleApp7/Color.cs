using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public abstract class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        private int grayscale;

        public Color(int red, int green, int blue, int alpha = 255)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public int Red { get { return red; } set { red = value; } }
        public int Green { get { return green; } set { green = value; } }
        public int Blue { get { return blue; } set { blue = value; } }
        public int Grayscale { get { return grayscale; } set { grayscale = value; } }
    }

    public class Ball : Color
    {
        private int size;
        private int throwCount;
        private int count;

        public Ball(int red, int green, int blue, int alpha = 255, int size) : base(red, green, blue, alpha) {}

        public int Size { get { return size; } set { size = value; } }
        public void Pop()
        {
            size = 0;
        }
        public void Throw()
        {
            throwCount+= 1;
            if (size == 0)
            {
                throwCount = 0;
            }
            count += 1;
        }
        public int Count() { return count; }
    }
}
