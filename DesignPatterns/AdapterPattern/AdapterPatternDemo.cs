using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public class AdapterPatternDemo
    {
        public MediaAdapter MediaAdapter
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public static void Output() 
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Play("MP3", "beyond the horizon.mp3");
            audioPlayer.Play("MP4", "alone.mp4");
            audioPlayer.Play("VLC", "far far away.vlc");
            audioPlayer.Play("AVI", "mind me.avi");
        }
    }
}
