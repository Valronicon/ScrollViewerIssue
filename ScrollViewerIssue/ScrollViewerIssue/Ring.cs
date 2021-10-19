using Xamarin.Forms;

namespace ScrollViewerIssue
{
    public class Ring
    {
        public Brush EllipseBackgroundColor { get; }

        public double Number { get; }

        public string Name { get; }

        public string Info { get; }

        public Ring (Color ellipseBackgroundColor, double number, string name, string info)
        {
            EllipseBackgroundColor = new SolidColorBrush (ellipseBackgroundColor);
            Number = number;
            Name = name;
            Info = info;
        }
    }
}
