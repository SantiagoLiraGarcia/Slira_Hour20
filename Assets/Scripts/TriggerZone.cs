using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    void OnTriggerEnter (Collider Other)
{
Destroy(Other.gameObject);
}

// Update is called once per frame

void Update()
    {
        
    }
}
