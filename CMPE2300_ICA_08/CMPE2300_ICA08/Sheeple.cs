using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace CMPE2300_ICA08
{
    class Sheeple
    {
        static Random _rng = new Random();
        public int _totalItem { get; private set; }
        public int _currentItem { get; private set; }
        public int _Color { get; private set; }
        public bool Done
        {
            get    
            {
                if (_currentItem == 0)
                    return true;
                else
                    return false;
            }
        }

        public void Process()
        {
            _currentItem--;
        }

         public Sheeple()
        {
            _totalItem = _rng.Next(2, 6);
            _currentItem = _totalItem;
            _Color = RandColor.GetColor().ToArgb();
        }

    }
}
