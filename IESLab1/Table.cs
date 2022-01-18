using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace IESLab1
{
    class Table
    {
        private Dictionary<Point, TextBox> textBoxes;
        
        public Dictionary<Point, TextBox> GetTextBoxes() { return textBoxes; }

        private void Configuration(TextBox textBox, Point location)
        {
            textBoxes[location].Size = new Size(25, 25);
            textBoxes[location].Location = location;
            textBoxes[location].Font = new Font("Microsoft Sans Serif", 12);
            textBoxes[location].MaxLength = 1;
            textBoxes[location].KeyPress += new KeyPressEventHandler(Key_Press);
            textBoxes[location].TextAlign = HorizontalAlignment.Center;
        }

        private void MadeDiagonal(int size)
        {
            for (int i = 0; i < size; ++i)
            {
                Point point = new Point(10 + i * 35, 10 + i * 35);
                textBoxes[point].Text = "0";
                textBoxes[point].Enabled = false;
            }
        }

        public Table(int size)
        {
            textBoxes = new Dictionary<Point, TextBox>();
            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    Point point = new Point(10 + j * 35, 10 + i * 35);
                    textBoxes.Add(point, new TextBox());
                    Configuration(textBoxes[point], point);
                }
            }
            MadeDiagonal(size);
        }

        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '1' && e.KeyChar != '0' && e.KeyChar != (Char)8)
            {
                e.Handled = true;
            }
        }

    }
}
