using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour
{
   Node _from;
   Node _to;
   int _cost;
   bool _traversed;

   public Edge(ref Node from, ref Node to)
   {
        _from = from;
        _to = to;
   }

   public void setEdges(ref Node from, ref Node to)
   {
        _from = from;
        _to = to;
   }

    public void setCost(int cost)
    {
        _cost = cost;
    }

   public Node getNodeFrom()
   {
        return _from;
   }

   public Node getNodeTo()
   {
        return _to;
   }
}
