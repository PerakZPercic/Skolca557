using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolca557.Adapter
{
    internal class Rectangle : IShape
    {
        private LegacyRectangle _Rect;

        public Rectangle(LegacyRectangle rect) => _Rect = rect;
        public Rectangle(int x, int y, int width, int height) => _Rect = new LegacyRectangle(x, y, width, height);

        public void Draw() => _Rect.DrawRectangle();
    }
}
