using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSEngager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
        public void ToggleChanged(bool newValue)
        {
            bool SEngager = newValue;
            ES2.Save(SEngager, "SEngager");
         }
}
