using UnityEngine;

public class Node : MonoBehaviour
{
    public Node[] ConnectsTo;
    public bool isLit;

    public void Switch()
    {
        isLit = !isLit;
    }
}
