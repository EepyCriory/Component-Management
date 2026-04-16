using UnityEngine;

public class SphereSpawning : MonoBehaviour
{
    //Attributes
    public GameObject spherePrefab;

    //Methods

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnSphere();
        }
    }

    private void SpawnSphere()
    {
        GameObject newSphere = Instantiate(spherePrefab, new Vector3(Random.Range(-10f, 10f), 1f, Random.Range(-5f, 5f)), Quaternion.identity);
    }
}