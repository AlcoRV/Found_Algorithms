using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IESLab1
{
    public partial class MainForm : Form
    {
        private Boolean IsMouseDown;
        private Point Position;
        private Dictionary<Point, TextBox> textBoxes;
        private Graphics graphics;

        public MainForm()
        {
            InitializeComponent();

            textBoxes = new Dictionary<Point, TextBox>();
            Table AdjacencyMatrix = new Table(DimensionTrackbar.Value);
            textBoxes = AdjacencyMatrix.GetTextBoxes();

            foreach (var item in textBoxes)
            {
                Controls.Add(item.Value);
            }

            IsMouseDown = false;
            DimensionValueLabel.Text = DimensionTrackbar.Value.ToString();
            graphics = CreateGraphics();
            Errors.Text = "";
        }

        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            WidthPath.Text = DepthPath.Text = "";
            WidthSteps.Text = DepthSteps.Text = "Количество шагов: ";
            Random random = new Random();
            for(int i = 0; i < DimensionTrackbar.Value; ++i)
            {
                for (int j = i+1; j < DimensionTrackbar.Value; ++j)
                {
                    Point true_point = new Point(10 + j * 35, 10 + i * 35);
                    Point simmectic_point = new Point(10 + i * 35, 10 + j * 35);
                    textBoxes[true_point].Text = textBoxes[simmectic_point].Text = random.Next(2).ToString();
                }
            }
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            WidthPath.Text = DepthPath.Text = "";
            WidthSteps.Text = DepthSteps.Text = "Количество шагов: ";

            try
            {
                if (IsTableFilled() && IsTextBoxesFilled())
                {
                    Errors.Text = "";
                    PathInGraph searcher = new PathInGraph();
                    searcher.TableValues = GetIntTable();
                    int start = Convert.ToInt32(StartField.Text);
                    int end = Convert.ToInt32(EndField.Text);
                    PrintPath(searcher.WidthFind(start, end), WidthPath);
                    WidthSteps.Text += searcher.Steps.ToString();
                    PrintPath(searcher.DepthFind(start, end), DepthPath);
                    DepthSteps.Text += searcher.Steps.ToString();
                }
            }
            catch (EnterException exception)
            {
                Errors.Text = exception.ToString();
            }
        }

        private Boolean IsTableFilled()
        {
            foreach(var item in textBoxes.Values)
            {
                if (item.Text.Equals(""))
                {
                    throw new EnterException("Ошибка в таблице!");
                }
            }
            return true;
        }

        private Boolean IsTextBoxesFilled()
        {
            if (StartField.Text == "")
                throw new EnterException("Ошибка начальной позиции!");
            if (EndField.Text == "")
                throw new EnterException("Ошибка конечной позиции!");
            return true;
        }

        private Dictionary<Point, int> GetIntTable()
        {
            Dictionary<Point, int> IntTable = new Dictionary<Point, int>();
            for(int i = 0; i < DimensionTrackbar.Value; i++)
            {
                for(int j = 0; j < DimensionTrackbar.Value; j++)
                {
                    Point AdditionPoint = new Point(10 + j * 35, 10 + i * 35);
                    IntTable.Add(new Point(j, i), Convert.ToInt32(textBoxes[AdditionPoint].Text));
                }
            }
            return IntTable;
        }

        private void PrintPath(List<int> path, TextBox field)
        {
            field.Text = "";
            foreach(var item in path.GetRange(0, path.Count-1))
            {
                field.Text += String.Format("{0}->", item.ToString());
            }
            field.Text += EndField.Text;
        }
    }
}
