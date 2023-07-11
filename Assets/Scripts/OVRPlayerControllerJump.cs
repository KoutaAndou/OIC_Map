using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRPlayerControllerJump : MonoBehaviour
{
    private OVRPlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<OVRPlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            playerController.Jump();
        }
    }
}
