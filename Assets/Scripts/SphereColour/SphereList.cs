using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class SphereList : MonoBehaviour
{
    //Attributes
    public List<string> sphereList = new List<string>();
    
    //Methods
    public void AddSphere(GameObject gameObject)
    {
        SphereColouring sphereColouring = gameObject.GetComponent<SphereColouring>();
        if (sphereColouring != null)
        {
            sphereList.Add(sphereColouring.sphereKPI.ToString());
        }
    }
}
