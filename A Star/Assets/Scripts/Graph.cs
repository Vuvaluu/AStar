using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    List<Node> nodes;

    public Graph()
    {
        nodes = new List<Node>();
    }

    public void Initialize()
    {
       // Edge edge1 = new Edge();
       // Edge edge2 = new Edge();
       // Edge edge3 = new Edge();
       // Edge edge4 = new Edge();
       // Edge edge5 = new Edge();
       // Edge edge6 = new Edge();
       // Edge edge7 = new Edge();
        //Edge edge8 = new Edge();
        //Edge edge9 = new Edge();
        //Edge edge10 = new Edge();
        //Edge edge11 = new Edge();
        
        //Node Node1 = new Node(new Vector2(2, 3), 10);
        //Node Node2 = new Node(new Vector2(4, 5), 12);
        //Node Node3 = new Node(new Vector2(6, 7), 14);
        //Node Node4 = new Node(new Vector2(8, 9), 16);
        //Node Node5 = new Node(new Vector2(5, 1), 13);
        //Node Node6 = new Node(new Vector2(8, 4), 3);
        //Node Node7 = new Node(new Vector2(3, 2), 3);
        //Node Node8 = new Node(new Vector2(5, 8), 7);
        //Node Node9 = new Node(new Vector2(4, 1), 0);

        //edge1.setEdges(ref Node1, ref Node2);

        //Node1.setEdge(new List<Edge> edge1, edge2);
    }

    public void AStar()
    {
        Queue<Node> porAnalizar = new Queue<Node>();
        Queue<Node> hold = new Queue<Node>();
    }

   /* public void Analizar(Node node)
    {
        int cost = 0;
        int mainCost = 0;
        int smallestNodeCostIndex = 0;
        for (int i = 0; 1 < Node.Edge.Count; i++)
        {
            Edge edge = node._Edges[i];
            cost = edge.getTo().Geth() + edge.GetCost();
            if(i == 0)
            {
                mainCost = cost;
                continue;
            }
            if (mainCost > cost)
            {
                mainCost = cost;
                smallestNodeCostIndex = i;
            }
        }
            porAnalizar. Enqueue(node._Edges[smallestNodeCostIndex] GetTo());

    }
   */
}
