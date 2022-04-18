namespace CourseAdv.ExtensionMethod
{
    public static class StringExtension
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException(nameof(numberOfWords));
            if (numberOfWords <= 0)
                return "";
            var words = str.Split(' ');
            if (words.Length < numberOfWords)
                return str;
            return String.Join(" ", words.Take(numberOfWords)); 
        }
    }
}
