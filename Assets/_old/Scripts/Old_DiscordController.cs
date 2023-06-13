using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour
{
    public Discord.Discord discord;

    public long applicationID;
    [Space]
    public string details = "";
    public string state = "";
    [Space]
    public string largeImage = "";
    public string largeText = "";

    private long time;
    // Start is called before the first frame update
    void Start()
    {
        discord = new Discord.Discord(applicationID, (System.UInt64)Discord.CreateFlags.Default);
        time = System.DateTimeOffset.Now.ToUnixTimeMilliseconds();
        UpdateStatus();
    }

    // Update is called once per frame
    void Update()
    {


        discord.RunCallbacks();
    }

    void LateUpdate()
    {
        UpdateStatus();
    }

    void UpdateStatus()
    {
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity {
            Details = details,
            State = state, 
            Assets = 
            {
                LargeImage = largeImage,
                LargeText = largeText
            },
            Timestamps =
            {
                Start = time
            }
        };
        activityManager.UpdateActivity(activity, (res) =>  {
            if (res == Discord.Result.Ok)
                Debug.Log("Discord status Set!");
            else
                Debug.LogError("Discord status failed!");
        });
    }
}
