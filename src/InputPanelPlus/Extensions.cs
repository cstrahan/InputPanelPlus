using System.Drawing;
using System.Windows.Forms;
using micautLib;

namespace InputPanelPlus
{
    public static class Extensions
    {
        public static Rectangle Position(this MathInputControl control)
        {
            int left, right, bottom, top;
            control.GetPosition(out left, out  top, out  right, out  bottom);
            var rect = new Rectangle(left, top, right - left, bottom - top);
            return rect;
        }

        public static Point Center(this Rectangle rectangle)
        {
            var point = new Point(rectangle.Left + rectangle.Width / 2, rectangle.Top + rectangle.Height / 2);
            return point;
        }

        public static void CenterOn(this Form form, Point point)
        {
            form.Location = new Point(point.X - form.Width / 2, point.Y - form.Height / 2);
        }
    }
}