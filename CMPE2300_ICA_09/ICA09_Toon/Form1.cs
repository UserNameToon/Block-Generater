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

namespace ICA09_Toon
{
    public partial class UI_Form : Form
    {
        static Random rng = new Random();
        List<Point> pointList = new List<Point>();
        LinkedList<Point> pointLink = new LinkedList<Point>();
        CDrawer canvas = new CDrawer();

        public UI_Form()
        {
            InitializeComponent();
        }

        private void UI_List_Butt_Click(object sender, EventArgs e)
        {
            pointList.Clear();    
            while (pointList.Count != ((canvas.ScaledWidth / (int)UI_NumUpDown.Value) * (canvas.ScaledHeight / (int)UI_NumUpDown.Value)))
            {
                Point newPoint = new Point(rng.Next(0, (canvas.ScaledWidth / (int)UI_NumUpDown.Value))* (int)UI_NumUpDown.Value,
                                           rng.Next(0, (canvas.ScaledHeight / (int)UI_NumUpDown.Value) )* (int)UI_NumUpDown.Value);
                if (pointList.Count == 0)
                    pointList.Add(newPoint);
                else
                {
                    if (!pointList.Contains(newPoint))
                        pointList.Add(newPoint);
                }
            }
            canvas.Clear();
            for (int i = 0; i < pointList.Count - 1; i++)
            {
                canvas.AddLine(pointList[i].X, pointList[i].Y, pointList[i + 1].X, pointList[i + 1].Y, Color.Magenta);
            }
            canvas.Render();
            Text = "Made N Points";
            UI_List_Butt.Text = "List contains: " + pointList.Count + " points";
        }

        private void UI_Link_Butt_Click(object sender, EventArgs e)
        {

            pointLink.Clear();
            foreach(Point i in pointList)
            {
                if (pointLink.Count == 0)
                    pointLink.AddFirst(i);
                else
                {
                    LinkedListNode<Point> nodePoint = pointLink.First;
                    while(nodePoint.Next != null && (i.Y * canvas.ScaledWidth + i.X) >= (nodePoint.Value.Y * canvas.ScaledWidth + nodePoint.Value.X))
                        nodePoint = nodePoint.Next;

                    if (nodePoint.Next == null && (i.Y * canvas.ScaledWidth + i.X) >= (nodePoint.Value.Y * canvas.ScaledWidth + nodePoint.Value.X))
                        pointLink.AddLast(i);
                    else
                        pointLink.AddBefore(nodePoint, i);      
                }
            }
            canvas.Clear();

            for (LinkedListNode<Point>  newNode = pointLink.First; newNode.Next != null; newNode = newNode.Next)
            {
                canvas.AddLine(newNode.Value.X, newNode.Value.Y, newNode.Next.Value.X, newNode.Next.Value.Y, Color.Yellow);
            }
            canvas.Render();
            UI_Link_Butt.Text = "LinkedList contains: " + pointLink.Count + " points";
        }

        private void UI_NumUpDown_ValueChanged(object sender, EventArgs e)
        {
            UI_List_Butt.Text = "Make list";
            UI_Link_Butt.Text = "Populate Linked List";
        }
    }
}
