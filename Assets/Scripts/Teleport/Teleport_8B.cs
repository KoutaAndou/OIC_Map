using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_8B : MonoBehaviour
{
    public OVRPlayerController playerController;
    public OVRCameraRig cameraRig;
    public Vector3 Position_8B;

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
    public void OnClick_8B()
    {
        playerController.GetComponent<CharacterController>().enabled = false;

        playerController.transform.position = Position_8B;

        playerController.GetComponent<CharacterController>().enabled = true;

        //�������烌�[�U�[�|�C���^�[�ƃ��j���[�폜�̏���
        laserPointer.GetComponent<LineRenderer>().enabled = false;
        menuParent.SetActive(false);
    }

}
