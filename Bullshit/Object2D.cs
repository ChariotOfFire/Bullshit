using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullshit
{
    class Object2D
    {
        // свойства
        public Point Position { get; private set; } // публичное, но изменять извне нельзя
        private Image _image;
        public int HitboxWidth { get; private set; }
        public int HitboxHeight { get; private set; }

        public Object2D() { } // конструктор - создает обьект
        // по умолчанию есть такой как вверху
        // но его можно скрыть... зачем - то
        // если создать свой конструктор - автоматический пропадает
        // например
        public Object2D(Image image)
        {
            _image = image;
        }
        // теперь он просит этот конструктор, private сделает то же самое
        public void Move() // void - тип возвращаемого значения (пустота)
        {
            Console.WriteLine("Hello world!");
        }


        // move()
        // `event on collision
        // `draw()
    }
}
