using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    abstract class Base
    {

        public abstract string Name { get; init; }
        public abstract void printName();

        public abstract void draw(Graphics g);

        public abstract void mark();

        public abstract void unmark();

        public abstract bool touched(int x, int y);

        public abstract bool is_marked();

        ~Base()
        {

        }
    }
}
