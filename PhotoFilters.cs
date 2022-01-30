namespace c_sharp_delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            System.Console.WriteLine("Apply Brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            System.Console.WriteLine("Apply Contrast");
        }
        public void Resize(Photo photo)
        {
            System.Console.WriteLine("Resize Photo");
        }
    }
}
