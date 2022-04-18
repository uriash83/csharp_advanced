namespace CourseAdv.Delegates
{
    // delegate przechowuje wskaznik do wywoania funckji lub grup funkcji
   
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);
        // mozna uzyc wbudowanego delegeta w .net


        public void Process(string path, Action <Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            
           

            photo.Save();
        }
    }
}
