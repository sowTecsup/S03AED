

public class Node<T> 
{
    private T value;

    private Node<T> next;

    public Node (T value)
    {
        this.value = value;
    }
    public void SetNext(Node<T> next)
    {
        this.next = next;
    }
    public Node<T> Next => next;
    public T Value => value;
}
