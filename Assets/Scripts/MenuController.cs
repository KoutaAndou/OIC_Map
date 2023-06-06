using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuParent;
    private Transform playerTransform;


    private bool isMenuVisible = false;

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
            menuParent.SetActive(isMenuVisible);
        }

        // ���j���[�I�u�W�F�N�g���v���C���[�̈ʒu�ɔz�u����
        if (playerTransform != null)
        {
            // �v���C���[�̈ʒu�Ƀ��j���[��z�u����
            menuParent.transform.position = playerTransform.position;

            // �v���C���[�̎����̌������擾����
            Vector3 playerForward = playerTransform.forward;

            // ���j���[�̌������v���C���[�̎����̌����ɍ��킹��
            menuParent.transform.rotation = Quaternion.LookRotation(playerForward);
        }
    }
}
