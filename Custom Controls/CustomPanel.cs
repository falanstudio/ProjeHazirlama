using System.Drawing.Drawing2D;

namespace Proje.Custom_Controls
{
    public partial class CustomPanel : Panel
    {
        public CustomPanel()
        {
            InitializeComponent();
        }

        public Color BorderColor { get; set; } = Color.Black;
        public int BorderWidth { get; set; } = 2;
        public bool IsHovered { get; set; } = false;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (IsHovered)
            {
                using (GraphicsPath path = CreateRoundedRectanglePath(ClientRectangle, 15)) // Adjust the radius as needed
                using (Pen borderPen = new Pen(BorderColor, BorderWidth))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
            
        }

        private GraphicsPath CreateRoundedRectanglePath(Rectangle rectangle, int radius)
        {
            int diameter = radius;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rectangle.Location, size);
            GraphicsPath path = new GraphicsPath();

            // Top left corner
            path.AddArc(arc, 180, 90);
            arc.X = rectangle.Right - diameter;

            // Top right corner
            path.AddArc(arc, 270, 90);
            arc.Y = rectangle.Bottom - diameter;

            // Bottom right corner
            path.AddArc(arc, 0, 90);
            arc.X = rectangle.Left;

            // Bottom left corner
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
