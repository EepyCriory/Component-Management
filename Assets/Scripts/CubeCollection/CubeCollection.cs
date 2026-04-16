using UnityEngine;

public class CubeCollection : MonoBehaviour
{
    //Attributes
    public CubeKPIManager CollectedCubesKPI;

    public Camera gameCamera;
    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit)) //Draws a line from the camera to the point where the raycast hits an object, for debugging purposes
        {
            Debug.DrawLine(gameCamera.transform.position, hit.point, Color.green);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //When the left mouse button is clicked, it checks if the raycast hits a cube and if so, it destroys the cube and updates the KPI
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Cube")) //Checks if the object hit by the raycast has the tag "Cube"
                {
                    Destroy(hit.collider.gameObject);
                    CollectedCubesKPI.SendData();
                }
            }
        }
    }
}
