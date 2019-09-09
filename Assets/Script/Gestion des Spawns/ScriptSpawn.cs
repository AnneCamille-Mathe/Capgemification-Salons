

using UnityEngine;
using System.Collections;

public class ScriptSpawn : MonoBehaviour {
    
   	void OnTriggerEnter (Collider Other)
    {
        Debug.Log("OnTriggerEnter");
        if(Other.gameObject.name== "RigidBodyFPSController")
        {
            Other.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;

        }	
	}		
}
