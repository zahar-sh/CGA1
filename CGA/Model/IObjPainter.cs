﻿using System.Windows.Media;

namespace CGA1.Model
{
    public interface IObjPainter
    {
        void Paint(Obj obj, ColorBuffer image, Color color);
    }
}
