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
    class Vertex
    {
        public int x, y;

        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Edge
    {
        public int v1, v2;

        public Edge(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
    class DrawGraph
    {
        Bitmap bitmap;
        
        Pen blackPen;
        Pen redPen;
        Pen darkGoldPen;
        Graphics gr;
        Font fo;
        Brush br;
        Brush gre;
        Brush re;
        PointF point;
        Pen greenPen;
        const double f = 2.75;
        
        public int R = 10; 

        public DrawGraph(int width, int height)
        {
            bitmap = new Bitmap(width, height);
            gr = Graphics.FromImage(bitmap);
           
            clearSheet();
            blackPen = new Pen(Color.Black);
            blackPen.Width = 2;
            redPen = new Pen(Color.Red);
            redPen.Width = 2;
            darkGoldPen = new Pen(Color.Black);
            darkGoldPen.Width = 2;
            fo = new Font("Arial", 10);
            br = Brushes.Black;
            re = Brushes.Red;
            gre = Brushes.LawnGreen;
            greenPen = new Pen(Color.LawnGreen, 2);
        }
       
        public Bitmap GetBitmap()
        {
 
            return bitmap;
        }
       
        public void clearSheet()
        {
            gr.Clear(Color.White);
            try
            {
                Rectangle compress = new Rectangle(0,0,bitmap.Width,bitmap.Height);

                gr.DrawImage(Form1.image,compress);
               
            }
            catch
            { }
        }

        public void drawVertex(int x, int y, string number)
        {

            

            gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
            gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
            point = new PointF(x - 9, y - 9);
            gr.DrawString(number, fo, br, point);
         
            

        }

        public void drawSelectedVertex(int x, int y)
        {
            gr.DrawEllipse(redPen, (x - R), (y - R), 2 * R, 2 * R);
        }

        public void drawEdge(Vertex V1, Vertex V2, Edge E, int numberE)
        {
            if (E.v1 != E.v2)
            {
                gr.DrawLine(darkGoldPen, V1.x, V1.y, V2.x, V2.y);
                point = new PointF((V1.x + V2.x) / 2, (V1.y + V2.y) / 2);
                // gr.DrawString(((char)('a' + numberE)).ToString(), fo, br, point);
                int s = Convert.ToInt32(Math.Sqrt(Math.Pow((V1.x - V2.x),2) + Math.Pow((V1.y - V2.y),2)));
                
              //  gr.DrawString(s.ToString(), fo, br, point);
                drawVertex(V1.x, V1.y, (E.v1 + 1).ToString());
                drawVertex(V2.x, V2.y, (E.v2 + 1).ToString());
            }
        }

        public void drawALLGraph(List<Vertex> V, List<Edge> E)
        {
            
            for (int i = 0; i < E.Count; i++)
            {
                if (E[i].v1 != E[i].v2)
                {
                    gr.DrawLine(darkGoldPen, V[E[i].v1].x, V[E[i].v1].y, V[E[i].v2].x, V[E[i].v2].y);
                    point = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
                    //  gr.DrawString(((char)('a' + i)).ToString(), fo, br, point);
                    int s = Convert.ToInt32(Math.Sqrt(Math.Pow((V[E[i].v1].x - V[E[i].v2].x), 2) + Math.Pow((V[E[i].v1].y - V[E[i].v2].y), 2)));

                   // gr.DrawString(s.ToString(), fo, br, point);
                }
            }
            
            for (int i = 0; i < V.Count; i++)
            {
                drawVertex(V[i].x, V[i].y, (i + 1).ToString());
            }
        }

        
        public void fillAdjacencyMatrix(int numberV, List<Edge> E, List<Vertex> V, int[,] matrix)
        {
            for (int i = 0; i < numberV; i++)
                for (int j = 0; j < numberV; j++)
                    matrix[i, j] = 0;
            for (int i = 0; i < E.Count; i++)
            {
                matrix[E[i].v1, E[i].v2] = Convert.ToInt32(Math.Round(Math.Sqrt(Math.Pow((V[E[i].v1].x - V[E[i].v2].x), 2) + Math.Pow((V[E[i].v1].y - V[E[i].v2].y), 2)), 2) );
                matrix[E[i].v2, E[i].v1] = Convert.ToInt32(Math.Round(Math.Sqrt(Math.Pow((V[E[i].v1].x - V[E[i].v2].x), 2) + Math.Pow((V[E[i].v1].y - V[E[i].v2].y), 2)), 2));
            }
        }
        public void drawALLGraphGr(List<Vertex> V, List<Edge> E,int[]g)
        {
            clearSheet();
           
            
            for (int i = 0; i < E.Count; i++)
            {
                if (E[i].v1 != E[i].v2)
                {
                    for(int j=1;j<g.Length;j++)
                    {
                        
                            gr.DrawLine(greenPen, V[g[j-1]-1].x, V[g[j-1]-1].y, V[g[j]-1].x, V[g[j]-1].y);
                        point = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
                      //  gr.DrawString(Convert.ToInt32(Math.Sqrt(Math.Pow((V[E[i].v1].x - V[E[i].v2].x), 2) + Math.Pow((V[E[i].v1].y - V[E[i].v2].y), 2))).ToString(), fo, br, point);

                    }
                    bool gg = false;
                    
                         for (int j = 0; j < g.Length; j++)
                         {
                             for (int q = 0; q < g.Length; q++)
                             {
                                 if (((E[i].v1 == g[j] - 1) && (E[i].v2 == g[q] - 1)) || ((E[i].v1 == g[q] - 1) && (E[i].v2 == g[j] - 1)))
                                     gg = true;
                             }
                         }
                    
                    if (gg == false)
                    {
                        gr.DrawLine(redPen, V[E[i].v1].x, V[E[i].v1].y, V[E[i].v2].x, V[E[i].v2].y);
                        point = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
                     //   gr.DrawString(Convert.ToInt32(Math.Sqrt(Math.Pow((V[E[i].v1].x - V[E[i].v2].x), 2) + Math.Pow((V[E[i].v1].y - V[E[i].v2].y), 2))).ToString(), fo, br, point);
                    }
                    else
                        point = new PointF((V[E[i].v1].x + V[E[i].v2].x) / 2, (V[E[i].v1].y + V[E[i].v2].y) / 2);
                    int s = Convert.ToInt32(Math.Sqrt(Math.Pow((V[E[i].v1].x - V[E[i].v2].x), 2) + Math.Pow((V[E[i].v1].y - V[E[i].v2].y), 2)));

                  //  gr.DrawString(s.ToString(), fo, br, point);
                }
            }
            for (int i = 0; i < V.Count; i++)
            {
                drawVertexx(V[i].x, V[i].y, (i + 1).ToString(),g);
            }
        }
        public void drawVertexx(int x, int y, string number,int[]g)
        {

            bool gg = false;
            for (int j = 0; j < g.Length; j++)
            {
                if(Convert.ToInt32(number)==g[j])
                    gg = true;
            }
            gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
            if (gg == true)
            {
                gr.DrawEllipse(greenPen, (x - R), (y - R), 2 * R, 2 * R);
                point = new PointF(x - 9, y - 9);
                gr.DrawString(number, fo, gre, point);
            }
            else
            {
                gr.DrawEllipse(redPen, (x - R), (y - R), 2 * R, 2 * R);
                point = new PointF(x - 9, y - 9);
                gr.DrawString(number, fo, re, point);
            }



        }




    }
}