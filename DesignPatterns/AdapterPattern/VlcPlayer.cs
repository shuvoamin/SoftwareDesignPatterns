using DesignPatterns.Interfaces;
using System;

namespace DesignPatterns.AdapterPattern
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public IAdvancedMediaPlayer IAdvancedMediaPlayer
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
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
