using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter _mediaAdapter;

        public Mp4Player Mp4Player
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IMediaPlayer MediaPlayer
        {
            get
            {
                throw new NotImplementedException();
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
            //_mediaAdapter is providing support to play other file formats
            else if ((audioType == "VLC") || (audioType == "MP4"))
            {
                _mediaAdapter = new MediaAdapter(audioType);
                _mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported" + Environment.NewLine);
            }
        }
    }
}
