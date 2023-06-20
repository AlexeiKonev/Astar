using UnityEngine;

public class PathFinder : MonoBehaviour
{
    Transform start;
    Transform target;
    public LayerMask mask;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
/// <summary>
/// €чейка
/// </summary>
public class Node
{
    public int G;
    public int F;
    public int H;
    public Node(int g)
    {
        G = g;
    }
}
