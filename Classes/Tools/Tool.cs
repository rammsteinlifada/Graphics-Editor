using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GraphicEditor.Classes;

namespace GraphicEditor.Classes
{
    public class Tool
    {
        protected bool Pressed = false;

        public virtual void MouseDown(Point point)
        {
            Pressed = true;
        }

        public virtual void MouseMove(Point point)
        {

        }

        public virtual void MouseUp(Point point)
        {
            Pressed = false;
        }
    }
}
