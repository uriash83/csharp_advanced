namespace CourseAdv.Exceptions
{
    internal partial class ProgramExceprion
    {
        public class YouTubeException : Exception
        {
            public YouTubeException(string message, Exception innerException)
                :base(message,innerException)
            {
                    
            }
        }
    }
}
