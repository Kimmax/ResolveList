﻿using System;
using System.Collections.Generic;

namespace ResolveList
{
    public class AllVideoInformationLoadedEventArgs : EventArgs
    {
        public AllVideoInformationLoadedEventArgs(List<YouTubeVideo> video)
        {
            this.Videos = video;
        }

        /// <summary>
        /// Returns the completed video object
        /// </summary>
        public List<YouTubeVideo> Videos { get; private set; }
    }
}