using SYMM;

namespace ResolveList
{
    public class SYMMSettings : ISYMMSettings
    {
        public string PathSafefileName { get; set; }
        public bool CheckDuplicate { get; private set; }
        public string DownloadURL { get; private set; }
        public string AlbumNameRegex { get; private set; }
        public short VideoResolution { get; private set; }
        public short AudioBitrate { get; private set; }
        public string SavePath { get; private set; }
        public AudioFormats AudioFormat { get; private set; }
        public Actions Action { get; private set; }
        public Mode DownloadMode { get; private set; }
        public URLSpecs UrlSpecs { get; private set; }

        public SYMMSettings(string downloadURL, string savePath, Mode downloadMode = Mode.Single, short videoResolution = 1080, bool checkDuplicate = true)
        {
            this.DownloadURL = downloadURL;
            this.SavePath = savePath;
            this.VideoResolution = videoResolution;
            this.CheckDuplicate = checkDuplicate;
            this.Action = Actions.Download;
            this.DownloadMode = downloadMode;
            this.UrlSpecs = URLSpecs.ExamineURL(downloadURL);
        }

        public SYMMSettings(string downloadURL, string savePath, Actions action, Mode downloadMode = Mode.Single, bool checkDuplicate = true, AudioFormats audioFormat = AudioFormats.mp3, short audioBitrate = 192)
        {
            this.DownloadURL = downloadURL;
            this.SavePath = savePath;
            this.Action = action;
            this.CheckDuplicate = checkDuplicate;
            this.AudioFormat = audioFormat;
            this.AudioBitrate = audioBitrate;
            this.DownloadMode = downloadMode;
            this.UrlSpecs = URLSpecs.ExamineURL(downloadURL);
        }

        public SYMMSettings(string streamURL, Actions action, Mode downloadMode = Mode.Single, short audioBitrate = 192)
        {
            this.DownloadURL = streamURL;
            this.Action = action;
            this.AudioBitrate = audioBitrate;
            this.DownloadMode = downloadMode;
            this.UrlSpecs = URLSpecs.ExamineURL(streamURL);
        }
    }
}
