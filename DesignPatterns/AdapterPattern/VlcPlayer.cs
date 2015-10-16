using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
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
            Console.WriteLine("Playing vlc file. Name: " +  fileName + Environment.NewLine);
        }

        //Override
        public void PlayMp4(string fileName)
        {
            //do nothing
        }
    }
}
