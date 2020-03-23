using System;

namespace Delegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
       {
           System.Console.WriteLine("Mail sender: sending mail" + args.Video.Title);
       }
    }
}