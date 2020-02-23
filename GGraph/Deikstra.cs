using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GGraph
{
    class Deikstra
    {
        
       public int[] Deikstra1(int SIZE, int[,] a,int start,int end)
        {
           
            
            int[] d = new int[SIZE]; 
            int[] v = new int[SIZE];
            int temp;
        int minindex, min;  
  for (int i = 0; i<SIZE; i++)
  {
    d[i] = 10000;
    v[i] = 1;
  }
  d[0] = 0;
  do {
    minindex = 10000;
    min = 10000;
    for (int i = 0; i<SIZE; i++)
    { 
      if ((v[i] == 1) && (d[i]<min))
      { 
        min = d[i];
        minindex = i;
      }
    }
    if (minindex != 10000)
    {
      for (int i = 0; i<SIZE; i++)
      {
        if (a[minindex,i] > 0)
        {
          temp = min + a[minindex,i];
          if (temp<d[i])
          {
            d[i] = temp;
          }
        }
      }
      v[minindex] = 0;
    }
  } while (minindex< 10000); 
            int[] ver = new int[SIZE]; 
          ver[0] = end + 1;
 
  int k = 1; 
int weight = d[end]; 

  while (end > start) 
  {
    for(int i=0; i<SIZE; i++) 
      if (a[end,i] != 0)   
      {
        int temp1 = weight - a[end,i]; 
        if (temp1 == d[i]) 
        {                 
          weight = temp1; 
          end = i;       
          ver[k] = i + 1; 
          k++;
        }
      }
  }
            int[] path = new int[k]; 
            for (int i = 0; i < k; i++)
                path[i] = ver[k - i - 1];
            return (path);
        }
       
    }
}
