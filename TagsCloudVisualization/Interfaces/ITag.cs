﻿#region

using System.Drawing;

#endregion

namespace TagsCloudVisualization.Interfaces
{
    public interface ITag
    {
        Rectangle Rectangle { get; }
        string Word { get; }
        int Frequency { get; }
    }
}