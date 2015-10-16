using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.AdapterPattern
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public IAdvancedMediaPlayer AdvancedMediaPlayer
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        //Override
        public void PlayVlc(string fileName)
        {
            //do nothing
        }

        //override
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName + Environment.NewLine);
        }
    }
}
