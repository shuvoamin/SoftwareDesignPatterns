using DesignPatterns.Interfaces;

namespace DesignPatterns.AdapterPattern
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advancedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType == "VLC")
            {
                advancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType == "MP4")
            {
                advancedMusicPlayer = new Mp4Player();
            }
        }

        public IMediaPlayer IMediaPlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public VlcPlayer VlcPlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType == "VLC")
            {
                advancedMusicPlayer.PlayVlc(fileName);
            }
            else if (audioType == "mp4")
            {
                advancedMusicPlayer.PlayMp4(fileName);
            }
        }
    }
}
