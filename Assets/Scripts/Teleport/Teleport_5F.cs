using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_5F : MonoBehaviour
{
    public OVRPlayerController playerController;
    public OVRCameraRig cameraRig;
    public Vector3 Position_5F;

    public GameObject menuParent;
    public LaserPointer laserPointer;

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
        playerController.GetComponent<CharacterController>().enabled = false;

        playerController.transform.position = Position_5F;

        playerController.GetComponent<CharacterController>().enabled = true;

        //ここからレーザーポインターとメニュー削除の処理
        laserPointer.GetComponent<LineRenderer>().enabled = false;
        menuParent.SetActive(false);
    }

}
