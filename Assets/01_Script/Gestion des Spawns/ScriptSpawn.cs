

using UnityEngine;
using System.Collections;

public class ScriptSpawn : MonoBehaviour {
    
    //Si l'utilsiateur entre dans la zone
   	void OnTriggerEnter (Collider Other)
    {
        if(Other.gameObject.name== "RigidBodyFPSController")
        {
            //On le respawn à l'endroit du spawn point
            Other.gameObject.transform.position = GameObject.Find("SpawnPoint").transform.position;
        }	
	}		
}
