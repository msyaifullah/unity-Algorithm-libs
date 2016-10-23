using UnityEngine;
using System.Collections;

public class DPDebug
{
	public static void Log (object message)
	{
		Debug.Log (message);
	}

	public static void LogWarning(object message){
		Debug.LogWarning( message);
	}
}
