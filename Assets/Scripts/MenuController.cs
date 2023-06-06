using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuParent;
    private Transform playerTransform;


    private bool isMenuVisible = false;

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
            isMenuVisible = !isMenuVisible;
            menuParent.SetActive(isMenuVisible);
        }

        // メニューオブジェクトをプレイヤーの位置に配置する
        if (playerTransform != null)
        {
            // プレイヤーの位置にメニューを配置する
            menuParent.transform.position = playerTransform.position;

            // プレイヤーの視線の向きを取得する
            Vector3 playerForward = playerTransform.forward;

            // メニューの向きをプレイヤーの視線の向きに合わせる
            menuParent.transform.rotation = Quaternion.LookRotation(playerForward);
        }
    }
}
