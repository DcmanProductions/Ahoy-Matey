using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkHud : NetworkManager
{

    public void StartLocalHost()
    {
        Debug.Log("Starting Local Host AT " + Time.timeSinceLevelLoad);
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log("Started Host At " + Time.timeSinceLevelLoad);
    }

}
