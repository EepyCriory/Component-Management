using UnityEngine;

public class SphereColouring : MonoBehaviour
{
    //Attributes
    public string[] colour = new string[5] { "Red", "Green", "Blue", "Black", "White" };
    public SphereKPI sphereKPI;

    private SphereSaver sphereSaver;

    //Methods
    private void Awake()
    {
        sphereSaver = FindFirstObjectByType<SphereSaver>();
    }

    private void Start()
    {
        int randomColour = Random.Range(0, colour.Length);

        switch (colour[randomColour])
        {
            case "Red":
                print("Red");
                sphereKPI = SphereKPI.SphereRed;
                sphereSaver.SaveData(sphereKPI);
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case "Green":
                print("Green");
                sphereKPI = SphereKPI.SphereGreen;
                sphereSaver.SaveData(sphereKPI);
                GetComponent<Renderer>().material.color = Color.green;
                break;
            case "Blue":
                print("Blue");
                sphereKPI = SphereKPI.SphereBlue;
                sphereSaver.SaveData(sphereKPI);
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            case "Black":
                print("Black");
                sphereKPI = SphereKPI.SphereBlack;
                sphereSaver.SaveData(sphereKPI);
                GetComponent<Renderer>().material.color = Color.black;
                break;
            case "White":
                print("White");
                sphereKPI = SphereKPI.SphereWhite;
                sphereSaver.SaveData(sphereKPI);
                GetComponent<Renderer>().material.color = Color.white;
                break;
            default:    
                print("Unknown Colour: " + colour[randomColour]);
                GetComponent<Renderer>().material.color = Color.white;
                break;

        }
    }
}