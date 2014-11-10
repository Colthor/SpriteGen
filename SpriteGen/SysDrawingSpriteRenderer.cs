using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SpriteGen
{
    class SysDrawingSpriteRenderer : ISpriteRenderer
    {
        public int SpriteWidth;
        public int SpriteHeight;
        public void RenderSegment(SegmentType type, float x, float y, float z, float angle, float height, float width)
        {
            Segment s = new Segment();
            s.type = type;
            s.x = x;
            s.y = y;
            s.z = z;
            s.angle = angle;
            s.height = height;
            s.width = width;

            SegList.Add(s);
        }

        public void RenderSprite(System.Drawing.Graphics g)
        {
            System.Drawing.Pen p = new Pen(Color.Black, 2);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SegList.Sort();

            foreach (Segment s in SegList)
            {
                g.TranslateTransform(s.x*SpriteWidth, s.y*SpriteHeight);
                g.RotateTransform(s.angle*57.2957795f);
                g.FillEllipse(redBrush, 0, 0, s.width*SpriteWidth, s.height*SpriteHeight);
                g.DrawEllipse(p, 0, 0, s.width*SpriteWidth, s.height*SpriteHeight);
                g.ResetTransform();
            }
        }

        private struct Segment : IComparable<Segment>
        {
            public int CompareTo(Segment s)
            {
                return -z.CompareTo(s.z);
            }

            public SegmentType type;
            public float x;
            public float y;
            public float z;
            public float angle;
            public float height;
            public float width;
        }

        private List<Segment> SegList = new List<Segment>();
    }
}
