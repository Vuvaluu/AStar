using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    Vector2 pos;
    List<Edge> _edges;
    int _holistic;
    bool _visited;
    Edge _correctEdge;

    public Node(Vector2 pos, List<Edge> edges, int holistic)
    {
        this.pos = pos;
        this._edges = edges;
        this._holistic = holistic;
    }

    public void setEdge(List<Edge> edges)
    {
        _edges = edges;
    }

    public void setHolisctic(int holistic)
    {
        _holistic = holistic;
    }

    public void setCorrectEdge(Edge edge)
    {
        _correctEdge = edge; 
    }

    public Edge getCorrectEdge()
    {
        return _correctEdge;
    }

    
}
