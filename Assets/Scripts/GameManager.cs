using System;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    public LinkedList<string> ListaDeNombres = new();

    void Start()
    {
        
    }
    void Update()
    {
        
    }

    [Button]
    public void TestMethod(string name, int value)
    {
        Debug.Log("Eureka");
    }


    [Button]
    public void TestNodes()
    {
        Node<string> a = new("juan");
        Node<string> b = new("juan2");
        Node<string> c = new("juan3");
        Node<string> d = new("juan4");
        Node<string> e = new("juan5");
        a.SetNext(b);
        b.SetNext(c);
        c.SetNext(d);
        d.SetNext(e);

        Node<string> Evaluator = a;
        while(Evaluator != null)
        {
            Debug.Log(Evaluator.Value);
            Evaluator = Evaluator.Next;
        }
    }

    [Button]
    public void TestLinkedList()
    {
        ListaDeNombres.Add("Juan");
        ListaDeNombres.Add("Juan2");
        ListaDeNombres.Add("Juan3");
        ListaDeNombres.Add("Juan4");
        ListaDeNombres.Add("Juan5");

        ListaDeNombres.Traverse();

    }
}
