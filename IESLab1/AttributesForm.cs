﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IESLab1
{
    public partial class MainForm : Form
    {
        private void StatusPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Position.X = -this.Width + StatusPanel.Width - e.X;
                Position.Y = -e.Y;
                IsMouseDown = true;
            }
        }

        private void StatusPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                Point MousePos = Control.MousePosition;
                MousePos.Offset(Position.X, Position.Y);
                Location = MousePos;
            }
        }

        private void StatusPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsMouseDown = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DimensionTrackBar_Scroll(object sender, EventArgs e)
        {
            DimensionValueLabel.Text = DimensionTrackbar.Value.ToString();
            StartField.Text = EndField.Text = "";
            WidthPath.Text = DepthPath.Text = "";

            foreach (var item in textBoxes)
            {
                Controls.Remove(item.Value);
            }
            textBoxes.Clear();

            Table tab = new Table(DimensionTrackbar.Value);
            textBoxes = tab.GetTextBoxes();

            foreach (var item in textBoxes)
            {
                Controls.Add(item.Value);
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Point point = new Point(this.Width * 3 / 5, this.Height * 3 / 5);
            Point point2 = new Point(this.Width * 4 / 5 - 60, this.Height * 3 / 5 + 50);
            graphics.DrawString("AK", new Font("Mistral", 100), Brushes.Black, point);
            graphics.DrawString("RV", new Font("Mistral", 100), Brushes.Maroon, point2);
        }

        private void FilterEnter(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 ||
                (int)Char.GetNumericValue(e.KeyChar) >= DimensionTrackbar.Value)
            {
                e.Handled = true;
            }
        }

    }
}
