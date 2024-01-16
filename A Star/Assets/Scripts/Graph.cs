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
        Edge edge1 = new Edge();
        Edge edge2 = new Edge();
        Edge edge3 = new Edge();
        Edge edge4 = new Edge();
        Edge edge5 = new Edge();
        Edge edge6 = new Edge();
        Edge edge7 = new Edge();
        Edge edge8 = new Edge();
        Edge edge9 = new Edge();
        Edge edge10 = new Edge();
        Edge edge11 = new Edge();

        List<Edge> List1 = new List<Edge>();
        List1.Add(edge1);
        List1.Add(edge7);

        List<Edge> List2 = new List<Edge>();
        List2.Add(edge1);
        List2.Add(edge2);
        List2.Add(edge6);

        List<Edge> List3 = new List<Edge>();
        List3.Add(edge3);
        List3.Add(edge5);

        List<Edge> List4 = new List<Edge>();
        List4.Add(edge3);
        List4.Add(edge4);
        
        List<Edge> List5 = new List<Edge>();
        List5.Add(edge5);
        List5.Add(edge8);

        List<Edge> List6 = new List<Edge>();
        List6.Add(edge6);
        List6.Add(edge7);
        List6.Add(edge8);
        List6.Add(edge9);

        List<Edge> List7 = new List<Edge>();
        List7.Add(edge9);
        List7.Add(edge10);

        List<Edge> List8 = new List<Edge>();
        List8.Add(edge4);
        List8.Add(edge11);

        List<Edge> List9 = new List<Edge>();
        List9.Add(edge10);
        List9.Add(edge11);

        
        Node Node1 = new Node(new Vector2(2, 3), List1, 10);
        Node Node2 = new Node(new Vector2(4, 5), List2, 12);
        Node Node3 = new Node(new Vector2(6, 7), List3, 14);
        Node Node4 = new Node(new Vector2(8, 9), List4, 16);
        Node Node5 = new Node(new Vector2(5, 1), List5, 13);
        Node Node6 = new Node(new Vector2(8, 4), List6, 3);
        Node Node7 = new Node(new Vector2(3, 2), List7, 3);
        Node Node8 = new Node(new Vector2(5, 8), List8, 7);
        Node Node9 = new Node(new Vector2(4, 1), List9, 0);
    }
}
