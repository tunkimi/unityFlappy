using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public static string path = Path.Combine(Application.dataPath, "Save.json");
    public static float MarioVelocity = 8;
    public static float PipeTimer = 1;
    private void Start()
    {
        path = Path.Combine(Application.dataPath, "Save.json");
        //data = LoadJSON.LoadingJSON<Data>();
        //LoadData(data)
    }

    public static void LoadData(SetData d)
    {
        MarioVelocity = d.vel;
        PipeTimer = d.timer;
    }






    private void OnApplicationQuit()
    {
        //SaveJSON.SaveFileJSON(data);
    }

}
public class SetData
{
    public float vel;
    public float timer;
    public SetData()
    {
        vel = Settings.MarioVelocity;
        timer = Settings.PipeTimer;
    }
}
