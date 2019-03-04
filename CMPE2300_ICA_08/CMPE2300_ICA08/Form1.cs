using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE2300_ICA08
{
    public partial class UI_Form : Form
    {
        Stack<Sheeple> mySheeple = new Stack<Sheeple>();
        List<Queue<Sheeple>> queue = new List<Queue<Sheeple>>();
        CDrawer canvas = null;
        int totalNum;
        int tickNum;

        public UI_Form()
        {
            InitializeComponent();
        }

        private void UI_Sim_Butt_Click(object sender, EventArgs e)
        {
            mySheeple.Clear();
            queue.Clear();
            for (int i = 0; i < UI_NumUpDown.Value; i++)
            {
                queue.Add(new Queue<Sheeple>());
            }
            if (canvas != null)
                canvas.Close();
            canvas = new CDrawer(800, 20 * (int)UI_NumUpDown.Value);
            canvas.Scale = 20;
            totalNum = 0;
            tickNum = 0;
            for (int i = 0; i < 200; i++)
            {
                mySheeple.Push(new Sheeple());
            }
        }

        private void UI_timer_Tick(object sender, EventArgs e)
        {
            if (canvas == null)
                return;
            if (mySheeple.Count != 0)
            {
                foreach (Queue<Sheeple> thisQueue in queue)
                {
                    if (thisQueue.Count < 10 && mySheeple.Count != 0)
                    {
                        thisQueue.Enqueue(mySheeple.Pop());

                    }
                }
            }
            UI_ListBox.Items.Clear();
            foreach (Sheeple i in mySheeple)
            {
                totalNum += i._totalItem;               
            }

            foreach (Queue<Sheeple> i in queue)
            {
                if (i.Count != 0)
                {
                    UI_ListBox.Items.Add(i.Count());
                    Sheeple temp = i.Peek();
                    temp.Process();
                    if (temp.Done)
                    {
                        totalNum += temp._totalItem;
                        i.Dequeue();
                    }
                }
                canvas.Clear();
                int sumX = 0;
                int sumY = 0;
                foreach (Queue<Sheeple> myQueue in queue)
                {
                    sumX = 0;
                    foreach (Sheeple eeple in myQueue)
                    {
                        canvas.AddRectangle(sumX, sumY, eeple._currentItem, 1, Color.FromArgb(eeple._Color));
                        sumX += eeple._currentItem;
                    }
                    sumY += 1;

                }
                canvas.Render();
            }
        }
    }
}
