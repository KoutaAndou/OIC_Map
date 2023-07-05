using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_4F : MonoBehaviour
{
    public OVRPlayerController playerController;
    public OVRCameraRig cameraRig;
    public Vector3 Position_4F;

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
    public void OnClick_4F()
    {
        playerController.GetComponent<CharacterController>().enabled = false;

        playerController.transform.position = Position_4F;

        playerController.GetComponent<CharacterController>().enabled = true;

        //ここからレーザーポインターとメニュー削除の処理
        laserPointer.GetComponent<LineRenderer>().enabled = false;
        menuParent.SetActive(false);
    }

}
