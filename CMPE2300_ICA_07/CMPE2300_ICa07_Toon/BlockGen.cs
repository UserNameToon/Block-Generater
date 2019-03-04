using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CMPE2300_ICa07_Toon
{
    public partial class BlockGen : Form
    {
        public BlockGen()
        {
            InitializeComponent();
        }

        List<Block> myBlock = new List<Block>();

        private void ShowBlock()
        {
            Block.Canvas.Clear();
            int sumWidth = 0;
            int sumHeight = 0;
            Point newPoint;
            foreach (Block b in myBlock)
            {
                if (b.Width <= Block.Canvas.ScaledWidth - sumWidth)
                {
                    newPoint = new Point(sumWidth, sumHeight);
                    sumWidth += b.Width;
                }
                else
                {
                    sumWidth = 0;
                    sumHeight += 20;
                    newPoint = new Point(sumWidth, sumHeight);
                    sumWidth += b.Width;
                }
                b.ShowBlock(newPoint);
            }
            Block.Canvas.Render();  
        }

        private void UI_Pop_butt_Click(object sender, EventArgs e)
        {
            int runningSumWidth = 0;
            myBlock.Clear();

            while (runningSumWidth < ((Block.Canvas.ScaledWidth * Block.Canvas.ScaledHeight) / 20) * 0.8)
            {
                Block temp = new Block();
                if (myBlock.Count == 0)
                {
                    myBlock.Add(temp);
                    runningSumWidth += temp.Width;
                }
                else
                {
                    for (int i = 0; i < myBlock.Count; i++)
                    {
                        if (!Block.Equals(temp, myBlock[i]))
                        {
                            myBlock.Add(temp);
                            runningSumWidth += temp.Width;
                            break;
                        }
                    }
                }
            }
            ChangeTrackBar();
            ShowBlock();
            
        }

        private void UI_Col_Butt_Click(object sender, EventArgs e)
        {
            myBlock.Sort();
            ShowBlock();
        }

        private void UI_Wid_Butt_Click(object sender, EventArgs e)
        {
            myBlock.Sort(Block.SortingWidth);
            ShowBlock();
        }

        private void UI_Wde_Butt_Click(object sender, EventArgs e)
        {
            myBlock.Sort(Block.SortingWidthDesc);
            ShowBlock();
        }

        private void UI_Wco_Butt_Click(object sender, EventArgs e)
        {
            myBlock.Sort(Block.SortingWidth_Color);
            ShowBlock();
        }

        private void UI_Bri_Butt_Click(object sender, EventArgs e)
        {
            int count = myBlock.Count();
            myBlock.RemoveAll(Block.Bright);
            ShowBlock();
            count = count - myBlock.Count();
            Text = "Blocks Remove : " + count;
            ChangeTrackBar();
        }

        private void UI_Lon_Butt_Click(object sender, EventArgs e)
        {
            
            myBlock.RemoveAll(obj => { if (obj == null) return false; return obj.Width > UI_Track.Value; });
            ChangeTrackBar();
            ShowBlock();
        }

        private void BlockGen_MouseMove(object sender, MouseEventArgs e)
        {

            myBlock.ForEach(obj => { obj.HighLight = false; });
            myBlock.FindAll(obj =>
            {
                if (obj.Width <= e.X + 10 && obj.Width >= e.X - 10)
                {
                    return obj.HighLight = true;
                }
                else
                    return false;
            }
                            );
            ShowBlock();
        }
        private void ChangeTrackBar()
        {
            myBlock.Min(obj => UI_Track.Minimum = obj.Width);
            myBlock.Max(obj => UI_Track.Maximum = obj.Width);
            if (UI_Track.Minimum >= 10)
            {
                if (UI_Track.Maximum != 10)
                UI_Track.Value = UI_Track.Maximum / 2;
            }
            UI_Lon_Butt.Text = "Longer than" + UI_Track.Value;
        }

        private void UI_Track_Scroll(object sender, EventArgs e)
        {
            UI_Lon_Butt.Text = "Longer than" + UI_Track.Value;
        }
    }
}
