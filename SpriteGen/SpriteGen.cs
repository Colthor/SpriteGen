using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpriteGen
{
    public enum SegmentType
    {
        OVAL,
        RECTANGLE
    };

    interface ISpriteRenderer
    {

        void RenderSegment(SegmentType type, float x, float y, float z, float angle, float height, float width);
    }

    class SpriteGen
    {
        public ISpriteRenderer Renderer;

        public void GenerateSprite()
        {
        }
    }
}
