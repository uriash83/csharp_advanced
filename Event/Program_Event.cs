using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAdv.Event
{
    internal class Program_Event
    {

        public static void EventVoid()
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();// publisher
            var mailService = new MailService(); // subscriber
            var textService = new TextService(); // subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textService.OnVideoEnc;
            videoEncoder.Encode(video);

        }
    }
}
