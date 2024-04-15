using UnityEngine;
using UnityEngine.Events;

public class CurlingFieldController : MonoBehaviour
{
    private Vector3 initialPosition; // 冰壺初始位置
    private bool isSiding = false;   // 冰壺是否正在滑行
    private Rigidbody rb;            // 冰壺的Rigidbody

    private void Start()
    {
        initialPosition = transform.position; // 保存冰壺的初始位置
        rb = GetComponent<Rigidbody>();       // 獲得冰壺的Rigidboby
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CurlingStone")) ; // 確認碰撞物體是冰壺
        {
            isSiding = true ;

        }
    }

    private void Update()
    {
        if (isSiding) 
        {
            // 每偵更新冰壺滑行距離
            float distance = Vector3.Distance(initialPosition, rb.velocity);
            // 待完成，冰壺停止時，紀錄距離
        
        }
    }


}
