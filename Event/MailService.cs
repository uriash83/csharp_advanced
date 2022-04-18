namespace CourseAdv.Event
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailServie: Sending an email..." + e.Video.Title);
        }
    }
}
