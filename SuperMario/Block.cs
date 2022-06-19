using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMario
{
    internal class Block
    {
        public int x, y, height, length;

        public Block(int x_, int _y, int _height, int _length)
        {
            this.x = x_;
            this.y = _y;
            this.height = _height;
            this.length = _length;
        }
        //public void Move( )
        //{

        //}
        
    }
}
