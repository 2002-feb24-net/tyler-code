using System;
using System.Threading;

namespace Delegates
{

    public class VideoEventArgs: EventArgs
    {
        public Video Video { get; set; }
    }
    
    public class VideoEnconder
    {
        //Define the delegate
        //Define an event bsed on the delegate
        //Raise the event

        public delegate void VideoEnconderEventHandler(object source, VideoEventArgs args);
        public event VideoEnconderEventHandler VideoEncoded;
        // public event EnventHandler<videoArgs> videoEncoded

        public void Enconde(Video vid1)
        {
            System.Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(vid1);
        }

        //How to raise an event
        protected virtual void OnVideoEncoded(Video vid1)
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = vid1 });
        }
    }
}