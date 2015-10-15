using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;

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

        public Mp4Player Mp4Player
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //Override
        public void Play(string audioType, string fileName)
        {
            //inbuilt support to play mp3 music files
            if (audioType == "MP3")
            {
                Console.WriteLine("Playing mp3 file. Name : " + fileName + Environment.NewLine);
            }
            //mediaAdapter is providing support to play other file formats
            else if ((audioType == "VLC") || (audioType == "MP4"))
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported" + Environment.NewLine);
            }
        }
    }
}
