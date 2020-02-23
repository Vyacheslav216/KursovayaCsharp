using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGraph
{
    public partial class Form1 : Form
    {
        
        DrawGraph G;
        
        List<Vertex> V;
        List<Edge> E;
       static  public Bitmap image;
        int[,] AMatrix; //матрица смежности
        int[,] DMatrix;
        int selected1; //выбранные вершины, для соединения линиями
        int selected2;
        bool start = false, finish = false;
        public Form1()
        {
            InitializeComponent();
            V = new List<Vertex>();
            G = new DrawGraph(sheet.Width, sheet.Height);
            E = new List<Edge>();
            // sheet.Image = G.GetBitmap();
           
            Vertexbutton.Enabled = false;
            Edgebutton.Enabled = false;
            Deletebutton.Enabled = false;
            Deikstrabutton.Enabled = false;
            sheet.Enabled = false;
            label1.Text = "";
            startBox.Enabled = false;
            finishBox.Enabled = false;

        }

        private void Vertexbutton_Click(object sender, EventArgs e)
        {
            Vertexbutton.Enabled = false;
            Edgebutton.Enabled = true;
            Deletebutton.Enabled = true;
           
            G.clearSheet();
            G.drawALLGraph(V, E);         
         sheet.Image= G.GetBitmap();
            sheet.Invalidate();

        }

        private void Edgebutton_Click(object sender, EventArgs e)
        {
            Vertexbutton.Enabled = true;
            Edgebutton.Enabled = false;
            Deletebutton.Enabled = true;
           
            G.clearSheet();
            G.drawALLGraph(V, E);
            sheet.Image = G.GetBitmap();
            selected1 = -1;
            selected2 = -1;
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            if (Vertexbutton.Enabled == false)
            {
                V.Add(new Vertex(e.X, e.Y));
                G.drawVertex(e.X, e.Y, V.Count.ToString());
                /* sheet.Width = image.Width;
                 sheet.Height = image.Height;*/
                startBox.Items.Add(Convert.ToString(V.Count.ToString()));
                finishBox.Items.Add(Convert.ToString(V.Count.ToString()));
                sheet.Image = G.GetBitmap();
              
            }
            if (Edgebutton.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < V.Count; i++)
                    {
                        if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                        {  
                            if (selected1 == -1)
                            {
                                G.drawSelectedVertex(V[i].x, V[i].y);
                                selected1 = i;
                                sheet.Image = G.GetBitmap();  
                                break;            
                            }
                            if (selected2 == -1)
                            {
                                G.drawSelectedVertex(V[i].x, V[i].y);
                                selected2 = i;
                                E.Add(new Edge(selected1, selected2));
                                G.drawEdge(V[selected1], V[selected2], E[E.Count - 1], E.Count - 1);
                                selected1 = -1;
                                selected2 = -1;
                                sheet.Image = G.GetBitmap();
                                break;
                            }
                        }
                    }
                }
            }

           
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            sheet.Image = null;
            Deletebutton.Enabled = false;
            Vertexbutton.Enabled = false;
            Edgebutton.Enabled = false;
            Deletebutton.Enabled = false;
            Deikstrabutton.Enabled = false;
            Mapbutton.Enabled = true;
            sheet.Enabled = false;
            
            V.Clear();
                E.Clear();
                G.clearSheet();
            //sheet.Image = G.GetBitmap(); 
            startBox.Items.Clear();
            finishBox.Items.Clear();
            startBox.Enabled = false;
            finishBox.Enabled = false;
            listBoxMatrix.Items.Clear();
            label1.Text = "";
        }

        private void Mapbutton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open_dialog = new OpenFileDialog(); 
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; 
            if (open_dialog.ShowDialog() == DialogResult.OK) 
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                   sheet.SizeMode = PictureBoxSizeMode.StretchImage;
                      sheet.Image = image;
                     sheet.Invalidate();
                    Vertexbutton.Enabled = true;
                    Edgebutton.Enabled = true;
                    Deletebutton.Enabled = true;
                   // Deikstrabutton.Enabled = true;
                    sheet.Enabled = true;
                    startBox.Enabled = true;
                    finishBox.Enabled = true;
                    start = false;
                    finish = false;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picture_MouseClick(object sender, MouseEventArgs e)
        {
            sheet_MouseClick(sender,  e);
        }

       

        private void Deikstrabutton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((startBox.SelectedItem != null) && (finishBox.SelectedItem != null))
                {
                    AMatrix = new int[V.Count, V.Count];
                    DMatrix = new int[V.Count, V.Count];
                    G.fillAdjacencyMatrix(V.Count, E, V, AMatrix);
                    listBoxMatrix.Items.Clear();
                    string sOut = "    ";
                    for (int i = 0; i < V.Count; i++)
                        sOut += (i + 1) + "       ";
                    listBoxMatrix.Items.Add(sOut);
                    for (int i = 0; i < V.Count; i++)
                    {
                        sOut = (i + 1) + " | ";
                        for (int j = 0; j < V.Count; j++)
                        {
                            sOut += AMatrix[i, j] + "    ";
                            DMatrix[i, j] = AMatrix[i, j];
                        }
                        listBoxMatrix.Items.Add(sOut);
                    }
                    Deikstra D = new Deikstra();
                    string h = "";
                    int[] g;
                    if (Convert.ToInt32(startBox.SelectedItem) < Convert.ToInt32(finishBox.SelectedItem))
                        g = D.Deikstra1(V.Count, DMatrix, Convert.ToInt32(startBox.SelectedItem) - 1, Convert.ToInt32(finishBox.SelectedItem) - 1);
                    else
                    {
                        g = D.Deikstra1(V.Count, DMatrix, Convert.ToInt32(finishBox.SelectedItem) - 1, Convert.ToInt32(startBox.SelectedItem) - 1);
                        int[] kq = new int[g.Length];
                        for (int i = 0; i < g.Length; i++)
                        {
                            kq[i] = g[i];
                        }

                        for (int i = 0; i < g.Length; i++)
                        {
                            g[i] = kq[g.Length - i - 1];
                        }

                    }
                    for (int i = 0; i < g.Length; i++)
                        h += g[i] + " -> ";
                    h = h.Remove(h.Length - 3, 3);
                    label1.Text = "Путь: " + h;
                    G.drawALLGraphGr(V, E, g);
                    sheet.Image = G.GetBitmap();
                    sheet.Invalidate();
                    Deletebutton.Enabled = false;
                    Vertexbutton.Enabled = false;
                    Edgebutton.Enabled = false;
                    Deletebutton.Enabled = true;
                    Deikstrabutton.Enabled = false;
                    sheet.Enabled = false;
                    Mapbutton.Enabled = false;
                    startBox.Enabled = false;
                    finishBox.Enabled = false;
                }
            }
            catch
            { }
        }

        private void finishBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (finishBox.SelectedItem != null)
                finish = true;
            if (finish && start)
                Deikstrabutton.Enabled = true;
        }

        private void startBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startBox.SelectedItem != null)
                start = true;
            if (finish && start)
                Deikstrabutton.Enabled = true;
        }
    }
}
