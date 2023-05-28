using System.Reflection;
using System.Reflection.Metadata.Ecma335;

namespace Win_Form_Paint_Homework {
    public partial class Form1 : Form {
        Point startPosition, endPosition;

        public Form1() {
            InitializeComponent();
        }

        private void label_Clicked(object? sender, MouseEventArgs e) {
            Label? label = sender as Label;
            this.Text = $"{label!.Location}";
        }

        private void label_DoubleClicked(object? sender, MouseEventArgs e) {
            Label? label = sender as Label;
            Controls.Remove(label);
        }

        private void Mouse_Down(object? sender, MouseEventArgs e) {
            startPosition = new(e.X, e.Y);
        }

        private void Mouse_Up(object? sender, MouseEventArgs e) {
            endPosition = new(e.X, e.Y);
            int width = Math.Abs(startPosition.X - endPosition.X);
            int height = Math.Abs(startPosition.Y - endPosition.Y);
            if (width < 10 || height < 10) {
                MessageBox.Show("Size of rectangle can't be lower than 10x10!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else {
                Label label = new();
                label.Size = new Size(width, height);
                label.BackColor = Color.Black;
                label.ForeColor = Color.Black;
                label.BorderStyle = BorderStyle.FixedSingle;
                int x = startPosition.X - endPosition.X;
                int y = startPosition.Y - endPosition.Y;
                if (x > 0 && y < 0) label.Location = new Point(endPosition.X, startPosition.Y);
                else if (x < 0 && y > 0) label.Location = new Point(startPosition.X, endPosition.Y);
                else if (x > 0 && y > 0) label.Location = endPosition;
                else if (x < 0 && y < 0) label.Location = startPosition;
                //else label.Location = endPosition;
                label.MouseClick += label_Clicked;
                label.MouseDoubleClick += label_DoubleClicked;
                Controls.Add(label);

                label.BringToFront();
            }
        }
    }
}