namespace CourseAdv.Event
{
    public class TextService
    {
        public void OnVideoEnc(object source, EventArgs e)
        {
            Console.WriteLine("Text service: Sending an sms...");
        }
    }
}
