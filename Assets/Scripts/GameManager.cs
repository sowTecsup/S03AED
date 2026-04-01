using System;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
   
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
 
   
}
