using DesignPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DesignPatterns.Interfaces.IMediaPlayer IMediaPlayer
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
