using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string name;
    public int age;
    
    public enum AType {cheeta, bird }
    public AType myAType;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public virtual void Eat()
    {
       
        Debug.Log("nom nom eat" + name);
    }

 
}
