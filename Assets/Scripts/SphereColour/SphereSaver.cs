using System.IO;
using UnityEngine;
using static CubeStatSaver;
public enum SphereKPI
{
    SphereRed,
    SphereGreen,
    SphereBlue,
    SphereWhite,
    SphereBlack
}
public class SphereSaver : MonoBehaviour
{
    [System.Serializable]
    public struct SphereData
    {
        public int redSpheres;
        public int greenSpheres;
        public int blueSpheres;
        public int whiteSpheres;
        public int blackSpheres;

        public void Save()
        {
            string json = JsonUtility.ToJson(this);
            File.WriteAllText(Application.persistentDataPath + "/sphereData.json", json);
        }
    }

    //Attributes
    public SphereData sphereData;

    //Methods
    private void Start()
    {
        LoadData(Application.persistentDataPath + "/sphereData.json");
    }
    public void LoadData(string path)
    {
         if (File.Exists(path))
         {
             string json = File.ReadAllText(path);
             sphereData = JsonUtility.FromJson<SphereData>(json);
        }
        else
        {
            sphereData.redSpheres = 0;
            sphereData.greenSpheres = 0;
            sphereData.blueSpheres = 0;
            sphereData.whiteSpheres = 0;
            sphereData.blackSpheres = 0;
        }
    }

    public void SaveData(SphereKPI dataType) //Update the data
    {
        switch (dataType)
        {
            case SphereKPI.SphereRed:
                sphereData.redSpheres++;
                break;
            case SphereKPI.SphereGreen:
                sphereData.greenSpheres++;
                break;
            case SphereKPI.SphereBlue:
                sphereData.blueSpheres++;
                break;
            case SphereKPI.SphereWhite:
                sphereData.whiteSpheres++;
                break;
            case SphereKPI.SphereBlack:
                sphereData.blackSpheres++;
                break;
        }
    }

    private void OnApplicationQuit()
    {
        sphereData.Save();
    }
}