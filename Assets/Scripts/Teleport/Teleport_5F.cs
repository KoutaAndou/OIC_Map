using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_5F : MonoBehaviour
{
    public OVRPlayerController playerController;
    public OVRCameraRig cameraRig;
    public Vector3 Position_5F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick_5F()
    {
        Vector3 offset;
        playerController.GetComponent<CharacterController>().enabled = false;

        offset = playerController.transform.position - cameraRig.transform.position;
        playerController.transform.position = Position_5F + offset;

        playerController.GetComponent<CharacterController>().enabled = true;
    }

}
