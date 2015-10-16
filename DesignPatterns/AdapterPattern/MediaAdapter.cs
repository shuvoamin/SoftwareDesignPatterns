using DesignPatterns.Interfaces;

namespace DesignPatterns.AdapterPattern
{
    public class MediaAdapter : IMediaPlayer
    {
        readonly IAdvancedMediaPlayer _advancedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType == "VLC")
            {
                _advancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType == "MP4")
            {
                _advancedMusicPlayer = new Mp4Player();
            }
        }

        public IMediaPlayer MediaPlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public VlcPlayer VlcPlayer
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType == "VLC")
            {
                _advancedMusicPlayer.PlayVlc(fileName);
            }
            else if (audioType == "mp4")
            {
                _advancedMusicPlayer.PlayMp4(fileName);
            }
        }
    }
}
