using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGameDemo.Snake
{
    interface IDrawable
    {
        public void Draw(Position point, char symbol);
    }
}
