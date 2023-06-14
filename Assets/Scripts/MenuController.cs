using UnityEngine;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{
    // ���j���[�̐e�v�f���w��
    public GameObject menuParent;

    // �v���C���[�̈ʒu���w��
    private Transform playerTransform;

    private bool isMenuVisible = false;
    private Vector3 menuPosition;
    private Quaternion menuRotation;

    void Start()
    {
        // �v���C���[�̈ʒu�����擾����
        playerTransform = OVRManager.instance?.transform;
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            // �{�^���������ꂽ�烁�j���[�̕\��/��\�����g�O������
            isMenuVisible = !isMenuVisible;

            if (isMenuVisible)
            {
                // ���j���[���\�������^�C�~���O�Ńv���C���[�̈ʒu�Ɖ�]���擾����
                menuPosition = playerTransform.position;
                menuRotation = playerTransform.rotation;
            }
            menuParent.SetActive(isMenuVisible);
        }

        // ���j���[�I�u�W�F�N�g���v���C���[�̈ʒu�ɔz�u����
        if (isMenuVisible && playerTransform != null)
        {
            // ���j���[�̈ʒu�Ɖ�]���Œ肵���l�ɐݒ肷��
            menuParent.transform.position = menuPosition + new Vector3(0,1.5f,0);
            menuParent.transform.rotation = menuRotation;
        }
    }
}
