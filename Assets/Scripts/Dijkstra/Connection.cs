using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Connection
{
    public float cost;
    public Node fromNode;
    public Node toNode;

    public Connection(float cost, Node fromNode, Node toNode)
    {
        this.cost = cost;
        this.fromNode = fromNode;
        this.toNode = toNode;
    }
    public float getCost(){ return cost; }
    public Node getFrom() { return fromNode; }
    public Node getTo() { return toNode; }
}
