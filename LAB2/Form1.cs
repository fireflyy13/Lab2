using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static LAB2.Form1;
using static System.Net.Mime.MediaTypeNames;



namespace LAB2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Method1_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            int v = 11;
            Graph g = new Graph(v);

            g.AddEdge(0, 3);
            g.AddEdge(0, 6);
            g.AddEdge(1, 8);
            g.AddEdge(1, 10);
            g.AddEdge(2, 5);
            g.AddEdge(3, 8);
            g.AddEdge(4, 7);
            g.AddEdge(4, 9);
            g.AddEdge(5, 9);

            g.AddDirEdge(1, 2);
            g.AddDirEdge(4, 2);
            g.AddDirEdge(2, 8);
            g.AddDirEdge(3, 7);
            g.AddDirEdge(4, 8);
            g.AddDirEdge(10, 5);

            StringBuilder textBuilder = new StringBuilder();
            int edgeCounter = 1;
            for (int i = 0; i < v; i++)
            {
                foreach (var adjVertex in g.adj[i])
                {
                    textBuilder.AppendLine($"Ребро {edgeCounter}: ({i + 1}, {adjVertex + 1})");
                    edgeCounter++;
                }
            }

            string text = textBuilder.ToString();

            int numColors = g.GraphColoring(v);

            MessageBox.Show($"Матриця суміжності:\n {text}\nКількість типів крамничок: {numColors}");

        }
        public class Graph
        {
            public List<int>[] adj;

            public Graph(int v)
            {
                adj = new List<int>[v];
                for (int i = 0; i < v; ++i)
                    adj[i] = new List<int>();
            }

            public void AddEdge(int v, int w)
            {
                adj[v].Add(w);
                adj[w].Add(v);
            }

            public void AddDirEdge(int v, int w)
            {
                adj[v].Add(w);
            }

            public int GraphColoring(int v)
            {
                int[] color = new int[v + 1];

                for (int i = 0; i < v; i++)
                {
                    color[i] = -1;
                }

                color[0] = 0;

                bool[] appropriate = new bool[v];

                for (int i = 0; i < v; i++)
                {
                    appropriate[i] = true;
                }

                for (int j = 1; j < v; j++)
                {
                    foreach (int k in adj[j])
                    {
                        if (color[k] != -1)
                            appropriate[color[k]] = false;
                    }


                    int colorFound;
                    for (colorFound = 0; colorFound < v; colorFound++)
                    {
                        if (appropriate[colorFound])
                            break;
                    }

                    color[j] = colorFound;

                    for (int i = 0; i < v; i++)
                    {
                        appropriate[i] = true;
                    }
                }

                HashSet<int> uniqueColors = new HashSet<int>(color);
                int numColors = uniqueColors.Count + 1;
                return numColors;

            }

        }
        private void Method2_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            int v = 11;
            Graph g2 = new Graph(v);
            g2.AddEdge(0, 3);
            g2.AddEdge(0, 6);
            g2.AddEdge(1, 8);
            g2.AddEdge(1, 10);
            g2.AddEdge(2, 5);
            g2.AddEdge(3, 8);
            g2.AddEdge(4, 7);
            g2.AddEdge(4, 9);
            g2.AddEdge(5, 9);

            g2.AddDirEdge(1, 2);
            g2.AddDirEdge(4, 2);
            g2.AddDirEdge(2, 8);
            g2.AddDirEdge(3, 7);
            g2.AddDirEdge(4, 8);
            g2.AddDirEdge(10, 5);

            int numColors = DSatur(g2.adj, v);

            StringBuilder textBuilder = new StringBuilder();
            int edgeCounter = 1;
            for (int i = 0; i < v; i++)
            {
                foreach (var adjVertex in g2.adj[i])
                {
                    textBuilder.AppendLine($"Ребро {edgeCounter}: ({i + 1}, {adjVertex + 1})");
                    edgeCounter++;
                }
            }
            string text = textBuilder.ToString();
            MessageBox.Show($"Матриця суміжності:\n {text}\nКількість типів крамничок: {numColors}");


        }
    
        static bool Solution2(int i, List<int>[] adj, List<int> color, int v)
        {
            if (i == adj.Length)
            {
                return true;
            }

            for (int j = 1; j <= v; j++)
            {
                if (IsAppropriate(i, adj, color, j))
                {
                    color[i] = j;

                    if (Solution2(i + 1, adj, color, v))
                    {
                        return true;
                    }

                    color[i] = 0;

                }
            }
            return false;
        }
        static bool IsAppropriate(int i, List<int>[] adj, List<int> color, int j)
        {
            foreach (int neighbor in adj[i])
            {
                if (color[neighbor] == j)
                {
                    return false;
                }
            }
            return true;
        }

        static int DSatur(List<int>[] adj, int v)
                {
            int l = adj.Length;

            List<int> color = new List<int>(new int[l]);

            if (!Solution2(0, adj, color, v))
            {
                return 0;
            }

            HashSet<int> uniqueColors = new HashSet<int>(color);
            return uniqueColors.Count + 1;
        }
        }
    }

