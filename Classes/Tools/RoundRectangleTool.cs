using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GraphicEditor.Classes;
using GraphicEditor.Classes.DifferentFigures;

namespace GraphicEditor.Classes.Tools
{
    class RoundRectangleTool : Tool
    {
        private bool Pressed = false;

        public RoundRectangleTool()
        {

        }

        public override void MouseDown(Point point)
        {
            Pressed = true;
            NotArtist.Figures.Add(new RoundRectangle(point));
        }

        public override void MouseMove(Point point)
        {
            if (Pressed)
                NotArtist.Figures[NotArtist.Figures.Count - 1].ChangeCord(point);
        }

        public override void MouseUp(Point point)
        {
            Pressed = false;
        }
    }
}
