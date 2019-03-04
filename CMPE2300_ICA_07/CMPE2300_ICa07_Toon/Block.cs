using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMPE2300_ICa07_Toon
{
    class Block : IComparable
    {
        private static Random _rng = new Random(1);
        private  Color _Color;
        public static CDrawer Canvas { get; private set; }

        public static int Height { get; private set; }

        public int Width { get; private set; }
        public bool HighLight { get; set; }

        static Block()
        {
            Height = 20;
            Canvas = new CDrawer();
            Canvas.BBColour = Color.White;
            Canvas.ContinuousUpdate = false;
        }

        public Block()
        {

            Width = _rng.Next(1, 20) * 10;
            HighLight = false;
            _Color = Color.FromArgb(_rng.Next(2, 8) * 32, _rng.Next(2, 8) * 16, _rng.Next(2, 8) * 16);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Block))
                return false;
            Block temp = obj as Block;
            return (Width == temp.Width) && (_Color == temp._Color);
        }
        public override int GetHashCode()
        {
            return 1;
        }
        public void ShowBlock(Point pLocation)
        {
            if (HighLight)
                Canvas.AddRectangle(pLocation.X, pLocation.Y, Width, Height, _Color, 2, Color.Yellow);
            else
                Canvas.AddRectangle(pLocation.X, pLocation.Y, Width, Height, _Color, 1, Color.Black);
        }

        //-----sorting-------------------
        public int CompareTo(object obj)
        {
            if (!(obj is Block))
                throw new ArgumentException("Something went wrong when try to sort color!!");
            Block temp = obj as Block;
            return _Color.ToArgb() - temp._Color.ToArgb();
        }

        public static int SortingWidth(object obj_1, object obj_2)
        {
            if (!(obj_1 is Block))
                throw new ArgumentException("Something went wrong!");
            if (!(obj_2 is Block))
                throw new ArgumentException("Something went wrong!");
            Block tempObj_1 = obj_1 as Block;
            Block tempObj_2 = obj_2 as Block;

            return tempObj_1.Width.CompareTo(tempObj_2.Width);
        }
        public static int SortingWidthDesc(object obj_1, object obj_2)
        {
            if (!(obj_1 is Block))
                throw new ArgumentException("Something went wrong!");
            if (!(obj_2 is Block))
                throw new ArgumentException("Something went wrong!");
            Block tempObj_1 = obj_1 as Block;
            Block tempObj_2 = obj_2 as Block;

            return  -tempObj_1.Width.CompareTo(tempObj_2.Width);
        }

        public static int SortingWidth_Color(object obj_1, object obj_2)
        {
            Block tempObj_1 = obj_1 as Block;
            Block tempObj_2 = obj_2 as Block;
            if (tempObj_1.Width == tempObj_2.Width)
            {
                return tempObj_1._Color.ToArgb() - tempObj_2._Color.ToArgb();
            }
            else
                return tempObj_1.Width - tempObj_2.Width;
           
        }

        public static bool Bright(Block obj)
        {

            if (obj == null)
                return false;
            return obj._Color.GetBrightness() > 0.5;
        }

    }
}
