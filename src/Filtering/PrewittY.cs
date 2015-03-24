﻿// ===============================================================================
// PrewittY.cs
// .NET Image Tools
// ===============================================================================
// Copyright (c) .NET Image Tools Development Group. 
// All rights reserved.
// ===============================================================================



namespace Nine.Imaging.Filtering
{
    /// <summary>
    /// Implements the prewitt filter for detection of vertical edges.
    /// </summary>
    public sealed class PrewittY : MatrixFilter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrewittY"/> class.
        /// </summary>
        public PrewittY()
        {
            double[] filter = new double[]
                                {
                                    -1, 0, 1,
                                    -1, 0, 1,
                                    -1, 0, 1
                                };

            Initialize(filter, 3);
        }
    }
}
