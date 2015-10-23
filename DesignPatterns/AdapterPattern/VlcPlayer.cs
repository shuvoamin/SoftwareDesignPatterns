using DesignPatterns.Interfaces;
using System;
using System.Diagnostics;

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
            Trace.WriteLine("Playing vlc file. Name: " +  fileName + Environment.NewLine);
        }

        //Override
        public void PlayMp4(string fileName)
        {
            //do nothing
        }
    }
}
