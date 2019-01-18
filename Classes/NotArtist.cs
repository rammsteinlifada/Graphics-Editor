using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using GraphicEditor.Classes;
using GraphicEditor.Classes.Tools;

namespace GraphicEditor.Classes
{
    static class NotArtist
    {
        public static List<Figure> Figures = new List<Figure>();

        public static FigureHost FigureHost = new FigureHost();

        public static System.Windows.Media.Pen pen = new System.Windows.Media.Pen(Brushes.Black, 2);

        public static Brush brush = new SolidColorBrush(Colors.Transparent);

        public static readonly List<Tool> Tools = new List<Tool>
        {
           new PencilTool(),
           new LineTool(),
           new EllipseTool(),
           new RectangleTool(),
           new RoundRectangleTool()
    };

        public static Tool SelectedTool = Tools[0];
    }
}
