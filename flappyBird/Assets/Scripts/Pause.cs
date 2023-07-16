using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseCanvas;
    public GameObject gameOverCanvas;
    public Text textVel;
    public Text textTime;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && gameOverCanvas.active == false)
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pauseCanvas.SetActive(false);

                var setData = new SetData();
                var jsonStr = JsonConvert.SerializeObject(setData);
                File.WriteAllText(Settings.path, jsonStr);
            }
            else
            {
                Time.timeScale = 0;
                textVel.text = $"Velocity: {Settings.MarioVelocity}";
                textTime.text = $"PipeTimer: {Settings.PipeTimer}";
                pauseCanvas.SetActive(true);
            }
        }
    }

    public void velPlus()
    {
        Settings.MarioVelocity++;
        textVel.text = $"Velocity: {Settings.MarioVelocity}";
    }
    public void velMin()
    {
        Settings.MarioVelocity--;
        textVel.text = $"Velocity: {Settings.MarioVelocity}";
    }
    public void timePlus()
    {
        Settings.PipeTimer++;
        textTime.text = $"PipeTimer: {Settings.PipeTimer}";
    }
    public void timeMin()
    {
        if(Settings.PipeTimer>1)
            Settings.PipeTimer--;
        textTime.text = $"PipeTimer: {Settings.PipeTimer}";
    }

}
