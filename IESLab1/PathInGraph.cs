using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IESLab1
{
    class PathInGraph
    {
        public Dictionary<Point, int> TableValues{ get; set; }
        public int Steps { get; private set; }

        private void FillList()
        {
            Node.nodes = new List<Node>();
            int size = TableValues.Last().Key.Y+1;
            for(int i = 0; i < size; i++)
            {
                Node.nodes.Add(new Node(i));
            }

            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    if(TableValues[new Point(j, i)] == 1)
                    {
                        Node.nodes[i].Children.Add(Node.nodes[j].Index);
                    }
                }
            }
        }

        private Boolean Contains(Node node, List<Node> nodes) //функция, определяющая, содержится ли вершина в
        {                                                          //каком-либо списке
            foreach(var item in nodes)
            {
                if (node.Equals(item)) return true;
            }
            return false;
        }

        public List<int> WidthFind(int start, int end) //алгоритм поиска в ширину
        {
            FillList();//заполнение матрицы смежности и создание основных контейнеров
            List<Node> Open = new List<Node>();
            List<Node> Closed = new List<Node>();
            Open.Add(Node.nodes[start]); //добавление начальной вершины в список Open
            Node node = Open.First(); 
            Steps = 1;

            while(!node.Equals(Node.nodes[end])) //проверка на соответствие целевой вершине
            {//добавление в конец Open всех дочерних вершин, которые не содержатся ни в каких списках
                Open.AddRange(node.GetChildren().Where(it => !Contains(it, Open) && !Contains(it, Closed)));
                Closed.Add(node);
                Open.Remove(node);
                if (Open.Count > 0)
                {
                    node = Open.First(); //переход к следующей вершине
                }
                else
                {
                    break; //выход из поиска, если Open пуст
                }
                Steps++;
            }

            if (!node.Equals(Node.nodes[end])) // проверка на соответствие последней просмотренной вершины и целевой
            {
                throw new EnterException("Путь не найден");
            }

            return GetPath(node); //возвращение пути до целевой вершины
        }

        public List<int> DepthFind(int start, int end)//алгоритм поиска в глубину
        {
            FillList();
            List<Node> Open = new List<Node>();
            List<Node> Closed = new List<Node>();
            Open.Add(Node.nodes[start]);
            Node node = Open.First();
            Steps = 1;

            while (!node.Equals(Node.nodes[end]))
            { //добавление в начало Open всех дочерних вершин, которые не содержатся ни в каких списках
                Open.InsertRange(0, node.GetChildren().Where(it => !Contains(it, Open) && !Contains(it, Closed)));
                Closed.Add(node);
                Open.Remove(node);
                if (Open.Count > 0)
                {
                    node = Open.First();
                }
                else
                {
                    break;
                }
                Steps++;
            }

            if (!node.Equals(Node.nodes[end]))
            {
                throw new EnterException("Путь не найден");
            }


            return GetPath(node);
        }

        private List<int> GetPath(Node lastNode) //функция, возвращающая путь от начальной вершины до целевой
        {
            List<int> Path = new List<int>();
            Node node = lastNode;
            while(node.Parent != null)
            {
                Path.Add(node.Index);
                node = node.Parent;
            }
            Path.Add(node.Index);
            Path.Reverse();

            return Path;
        }

        private class Node
        {
            public static List<Node> nodes { get; set; } //все узлы графа
            public List<int> Children { get; set; } //дочерние вершины
            public int Index { get; } //номер вершины
            public Node Parent { get; } //вершина-родитель

            public Node(int index) //конструктор создания начальной вершины
            {
                this.Index = index;
                Children = new List<int>();
            }

            public Node(Node copy, Node parent) //конструктор создания дочерней вершины
            {
                this.Index = copy.Index;
                Children = copy.Children;
                this.Parent = parent;
            }

            public List<Node> GetChildren() //Функция, возвращающая множество дочерних вершин
            {
                List<Node> children = new List<Node>();
                foreach(int item in Children)
                {
                    children.Add(new Node(nodes[item], this));
                }
                return children;
            }

            public Boolean Equals(Node another) //Функция сравнения двух вершин
            {
                return this.Index == another.Index;
            }
        }
    }
}
