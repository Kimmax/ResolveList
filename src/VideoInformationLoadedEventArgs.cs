using System;

namespace ResolveList
{
    public class VideoInformationLoadedEventArgs : EventArgs
    {
        public VideoInformationLoadedEventArgs(YouTubeVideo video)
        {
            this.Video = video;
        }

        /// <summary>
        /// Returns the completed video object
        /// </summary>
        public YouTubeVideo Video { get; private set; }
    }
}