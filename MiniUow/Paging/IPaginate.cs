﻿//-----------------------------------------------------------------------
// <copyright>
// Copyright (c) CanhHungIT. All rights reserved.
// https://www.nuget.org/packages/MiniUow/
// </copyright>
//-----------------------------------------------------------------------

using System.Collections.Generic;

namespace MiniUow.Paging
{
    public interface IPaginate<T>
    {
        int From { get; }

        int Index { get; }

        int Size { get; }

        int Count { get; }

        int Pages { get; }

        IEnumerable<T> Items { get; }

        bool HasPrevious { get; }

        bool HasNext { get; }
    }
}