using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordRich : MonoBehaviour {

	public Discord.Discord discord;

	// Use this for initialization
	void Start () {
		discord = new Discord.Discord(626858695556595714, (System.UInt64)Discord.CreateFlags.Default);
		var activityManager = discord.GetActivityManager();
		var activity = new Discord.Activity
		{
			Details = "I am playing the beta version of SphereRPG, I am so cool"
		};
		activityManager.UpdateActivity(activity, (res) =>
		{
			if (res == Discord.Result.Ok)
			{
				Debug.LogError("Everything is fine!");
			}
		});
	}
	
	// Update is called once per frame
	void Update () {
		discord.RunCallbacks();
	}
}