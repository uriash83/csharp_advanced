namespace CourseAdv.Event
{
    // musi dziedziczyc po EventArgs
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {

        // nazwa delegate = classname+EventHanderl


        //public delegate void VideoEncodedEventHandel(object source, VideoEventArgs args); //EventArgs
        //public event VideoEncodedEventHandel VideoEncoded;
        // zamiast 2 powyzszych linijej mozna napisac 1 jak nizej


        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encode video ....");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (this.VideoEncoded != null)
                this.VideoEncoded(this, new VideoEventArgs() { Video = video });// this - current class, EventArgs.Empty - zwraca emplty instance of EventArgs ktora jest pusta
        }
    }
}
