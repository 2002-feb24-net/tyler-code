using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoMain = new Video() {Title = "My video"};
            var encodeObj = new VideoEnconder(); //publisher
            var service = new MailService(); //Subscriber
            var text = new MessageService(); //subscriber

            encodeObj.VideoEncoded += text.OnVideoEncoded;
            encodeObj.VideoEncoded += service.OnVideoEncoded;

            encodeObj.Enconde(videoMain);

        }
    }
}
