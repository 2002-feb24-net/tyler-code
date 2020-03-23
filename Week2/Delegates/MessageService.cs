using System;

namespace Delegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            System.Console.WriteLine("Messaging services: sending text message..." + args.Video.Title);
        }
    }
}