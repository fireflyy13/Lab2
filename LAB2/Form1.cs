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
            panel1.Height = 60;
        }

        private void Method1_Click(object sender, EventArgs e)
        {
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
            g.AddDirEdge(10, 5);

            int numColors = g.GraphColoring(v);
            label1.BackColor = Color.Ivory;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Text = ($"Жадібний алгоритм\nКількість типів \nкрамничок: {numColors}");

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
                int[] colors = new int[v + 1];

                for (int i = 0; i < v; i++)
                {
                    colors[i] = -1;
                }

                colors[0] = 0;

                bool[] appropriate = new bool[v];

                for (int i = 0; i < v; i++)
                {
                    appropriate[i] = true;
                }

                for (int j = 1; j < v; j++)
                {
                    foreach (int k in adj[j])
                    {
                        if (colors[k] != -1)
                            appropriate[colors[k]] = false;
                    }


                    int colorFound;
                    for (colorFound = 0; colorFound < v; colorFound++)
                    {
                        if (appropriate[colorFound])
                            break;
                    }

                    colors[j] = colorFound;

                    for (int i = 0; i < v; i++)
                    {
                        appropriate[i] = true;
                    }
                }

                HashSet<int> uniqueColors = new HashSet<int>(colors);
                int numColors = uniqueColors.Count + 1;
                return numColors;

            }

        }
        private void Method2_Click(object sender, EventArgs e)
        {
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

            g2.AddDirEdge(10, 5);

            int numColors = Backtracking(g2.adj, v);

            label1.BackColor = Color.Ivory;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Text = ($"Пошук з вертанням\nКількість типів \nкрамничок: {numColors}");
        }

        static bool Solution2(int i, List<int>[] adj, List<int> colors2, int v)
        {
            if (i == adj.Length)
            {
                return true;
            }

            for (int j = 1; j <= v; j++)
            {
                if (IsAppropriate(i, adj, colors2, j))
                {
                    colors2[i] = j;

                    if (Solution2(i + 1, adj, colors2, v))
                    {
                        return true;
                    }

                    colors2[i] = 0;

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

        static int Backtracking(List<int>[] adj, int v)
        {
            int l = adj.Length;

            List<int> colors2 = new List<int>(new int[l]);

            if (!Solution2(0, adj, colors2, v))
            {
                return 0;
            }

            HashSet<int> uniqueColors = new HashSet<int>(colors2);
            return uniqueColors.Count + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (panel1.Height == 163)
            {
                panel1.Height = 60;
            }

            else
            {
                panel1.Height = 163;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
