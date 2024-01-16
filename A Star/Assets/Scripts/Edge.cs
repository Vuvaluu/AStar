using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour
{
   Node _from;
   Node _to;
   int cost;

   public Edge(ref Node from, ref Node to)
   {
        _from = from;
        _to = to;
   }

   public Edge()
   {

   }

   public void setEdge(ref Node from, ref Node to)
   {
        _from = from;
        _to = to;
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
