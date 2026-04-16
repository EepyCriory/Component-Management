using System.IO;
using System.Net.Sockets;
using UnityEngine;

public class CubeStatSaver : MonoBehaviour
{
    [System.Serializable]
    public struct CubeData //Struct to hold the data
    {
        public int collectionCount;

        public void Save(string path) //Save the data to a file in JSON format
        {
            string jsonString = JsonUtility.ToJson(this);
            File.WriteAllText(path, jsonString);
        }
    }

    //Attributes
    public CubeData cubeData;

    //Methods
    private void Start()
    {
        string path = Application.persistentDataPath + "/CubeCollectionData.json";
        LoadData(path);
    }

    public void LoadData(string path) //Load the data from a file
    {
        if (File.Exists(path)) //Check if the file exists
        {
            string jsonString = File.ReadAllText(path);
            cubeData = JsonUtility.FromJson<CubeData>(jsonString);
        }
        else //If the file doesn't exist, initialize the data
        {
            cubeData.collectionCount = 0;
        }
    }

    public void SaveData(CubeKPI dataType) //Update the data
    {
        switch (dataType)
        {
            case CubeKPI.CollectedCubesKPI:
                cubeData.collectionCount++;
                break;
        }
    }

    private void OnDestroy() //Save the data when the object is destroyed
    {
        cubeData.Save(Application.persistentDataPath + "/CubeCollectionData.json");
    }
}
