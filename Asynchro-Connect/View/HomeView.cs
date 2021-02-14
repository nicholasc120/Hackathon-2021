using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asynchro_Connect.View
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
            this.homeTab.DrawMode = (TabDrawMode)DrawMode.OwnerDrawFixed;
            this.homeTab.DrawItem += new DrawItemEventHandler(homeView_DrawItem);

        }

        // Method modified from https://stackoverflow.com/questions/30822870/recoloring-tabcontrol
        // and https://stackoverflow.com/questions/11822748/how-to-change-the-background-color-of-unused-space-tab-in-c-sharp-winforms
        private void homeView_DrawItem(object sender, DrawItemEventArgs e)
        {
            // get ref to this page
            TabPage tp = ((TabControl)sender).TabPages[e.Index];
            TabPage selectedTab = ((TabControl)sender).TabPages[this.homeTab.SelectedIndex];
            Color myColor = Color.Thistle;
            if (tp == selectedTab)
            {
                // Use a color slightly darker than Thistle
                myColor = Color.FromArgb(206, 175, 206);
            }
            using (Brush br = new SolidBrush(myColor))
            {
                Rectangle rect = e.Bounds;
                e.Graphics.FillRectangle(br, e.Bounds);

                // Fill in the colour of the space
                Rectangle lasttabrect = this.homeTab.GetTabRect(this.homeTab.TabPages.Count - 1);
                RectangleF emptyspacerect = new RectangleF(
                        lasttabrect.X + lasttabrect.Width + this.homeTab.Left,
                        this.homeTab.Top + lasttabrect.Y,
                        this.homeTab.Width - (lasttabrect.X + lasttabrect.Width),
                        lasttabrect.Height);

                e.Graphics.FillRectangle(br, emptyspacerect);

                rect.Offset(1, 1);
                TextRenderer.DrawText(e.Graphics, tp.Text,
                       tp.Font, rect, tp.ForeColor);

                // draw the border
                rect = e.Bounds;
                rect.Offset(0, 1);
                rect.Inflate(0, -1);

                // ControlDark looks right for the border
                using (Pen p = new Pen(SystemColors.ControlDark))
                {
                    e.Graphics.DrawRectangle(p, rect);
                }

                if (e.State == DrawItemState.Selected) e.DrawFocusRectangle();

            }
        }

        private void HomeView_BackColorChanged(object sender, EventArgs e)
        {
            Console.WriteLine("PINEAPPLE");
        }

        private void HomeView_ForeColorChanged(object sender, EventArgs e)
        {
            Console.WriteLine("PINEAPPLE");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

    }
}
