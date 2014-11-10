using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpriteGen
{
    public partial class SpriteEditor : Form
    {
        public SpriteEditor()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            
            SysDrawingSpriteRenderer sr = new SysDrawingSpriteRenderer();
            sr.SpriteHeight = 300;
            sr.SpriteWidth = 300;
            sr.RenderSegment(SegmentType.OVAL, 0.25f, 0.25f, 0.25f, 0f, .25f, .1f);
            sr.RenderSegment(SegmentType.OVAL, 0.25f, 0.25f, 0.5f, .5f, .25f, .1f);
            sr.RenderSegment(SegmentType.OVAL, 0.25f, 0.25f, 0.75f, 1f, .25f, .1f);
            sr.RenderSegment(SegmentType.OVAL, 0.25f, 0.25f, 0.85f, 1.5f, .25f, .1f);
            sr.RenderSegment(SegmentType.OVAL, 0.25f, 0.25f, 0.95f, 2f, .25f, .1f);



            sr.RenderSprite(e.Graphics /*pictureBox1.CreateGraphics()*/);
           /* e.Graphics.DrawEllipse(new Pen(Color.Black, 2), 0, 0, 50, 50);
            e.Graphics.DrawString("This is a diagonal line drawn on the control",
    new Font("Arial", 10), System.Drawing.Brushes.Blue, new Point(30, 30));
            // Draw a line in the PictureBox.
            e.Graphics.DrawLine(System.Drawing.Pens.Red, pictureBox1.Left, pictureBox1.Top,
                pictureBox1.Right, pictureBox1.Bottom);
            e.Graphics.DrawEllipse(new Pen(Color.Black, 2), 50, 50, 50, 50);*/
        }

        private void SpriteEditor_Load(object sender, EventArgs e)
        {
            //pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.BackColor = Color.White;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

    }
}
