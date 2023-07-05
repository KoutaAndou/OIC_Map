using UnityEngine;
using UnityEngine.EventSystems;

public class MenuController : MonoBehaviour
{
    // メニューの親要素を指定
    public GameObject menuParent;
    public LaserPointer laserPointer;

    // プレイヤーの位置を指定
    private Transform playerTransform;

    private bool isMenuVisible = false;
    private bool isLaserPointerVisible = false;

    private Vector3 menuPosition;
    private Quaternion menuRotation;

    void Start()
    {
        // プレイヤーの位置情報を取得する
        playerTransform = OVRManager.instance?.transform;
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            // ボタンが押されたらメニューの表示/非表示をトグルする
            isMenuVisible = !menuParent.activeSelf;
            isLaserPointerVisible = !laserPointer.GetComponent<LineRenderer>().enabled;


            if (isMenuVisible)
            {
                // メニューが表示されるタイミングでプレイヤーの位置と回転を取得する
                menuPosition = playerTransform.position;
                menuRotation = playerTransform.rotation;
            }

            laserPointer.GetComponent<LineRenderer>().enabled = isLaserPointerVisible;
            menuParent.SetActive(isMenuVisible);
        }

        // メニューオブジェクトをプレイヤーの位置に配置する
        if (isMenuVisible && playerTransform != null)
        {
            // メニューの位置と回転を固定した値に設定する
            menuParent.transform.position = menuPosition;
            menuParent.transform.rotation = menuRotation;
        }
    }
}
