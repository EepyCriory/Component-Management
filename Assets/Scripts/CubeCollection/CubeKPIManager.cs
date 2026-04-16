using UnityEngine;

public enum CubeKPI //Enum for the stat tracking
{
    CollectedCubesKPI = 0
}

public class CubeKPIManager : MonoBehaviour
{
    //Attributes
    public CubeKPI kpi;

    private CubeStatSaver dataManager;

    //Methods
    private void Awake() //Find the CubeStatSaver in the scene
    {
        dataManager = FindFirstObjectByType<CubeStatSaver>();
    }

    public void SendData() //Sends the data to the CubeStatSaver
    {
        print("Data sent: " + kpi);
        dataManager.SaveData(kpi);
    }
}
