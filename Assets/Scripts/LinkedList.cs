

using UnityEngine;

public class LinkedList<T>
{
    public Node<T> head = null;


    public void Add(T value)
    {
        Node<T> tempNode = new(value);

        //-> Cuando no hay nuingun elemento en la lista
        if (head == null)
        {
            head = tempNode;
        }
        else
        {
            Node<T> Evaluator = head;

            while(Evaluator.Next != null)
            {
                Evaluator = Evaluator.Next;
            }

            Evaluator.SetNext(tempNode);

        }
    }

    public void Traverse()
    {
        Node<T> Evaluator = head;
        while (Evaluator != null)
        {
            Debug.Log(Evaluator.Value);
            Evaluator = Evaluator.Next; 
        }
    }

}
