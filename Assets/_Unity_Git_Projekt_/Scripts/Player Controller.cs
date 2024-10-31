using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();

        if (cc == null) {
            Debug.LogError("Character Controller Component is Missing");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
