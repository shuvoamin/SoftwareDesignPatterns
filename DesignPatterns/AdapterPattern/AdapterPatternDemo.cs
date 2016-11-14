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
        }
    
        public static void Output() 
        {
            var audioPlayer = new AudioPlayer();

            audioPlayer.Play("MP3", "beyond the horizon.mp3");
            audioPlayer.Play("MP4", "alone.mp4");
            audioPlayer.Play("VLC", "far far away.vlc");
            audioPlayer.Play("AVI", "mind me.avi");
        }
    }
}
