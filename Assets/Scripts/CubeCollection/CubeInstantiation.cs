using UnityEngine;

public class CubeInstantiation : MonoBehaviour
{
    //Attributes
    public int spawnCount;
    public GameObject cube;

    //Methods
    void Awake() //Randomly sets the spawn count between 3 and 20
    {
        spawnCount = Random.Range(3, 21);
    }

    void Start()
    {
        Spawn();
    }

    void Spawn() //Spawns the cubes in random positions within a defined area
    {
        for (int i = 0; i < spawnCount; i++)
        {
            Instantiate(cube, new Vector3(Random.Range(-15f, 15f), 0, Random.Range(-5f, 5f)), Quaternion.identity);
        }
    }
}
