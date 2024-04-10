using UnityEngine;
using UnityEngine.Events;

public class CurlingFieldController : MonoBehaviour
{
    public UnityEvent<double> OnBallStopAtFirstCircle;
    public UnityEvent<double> OnBallStopAtSecondCircle;

    public float firstCircleRadius = 5f; // 第一个圆的半径
    public float secondCircleRadius = 10f; // 第二个圆的半径

    private Vector3 initialPosition;
    private Rigidbody ballRigidbody;
    private bool isMoving = false;

    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    void Update()
    {
        if (isMoving && ballRigidbody.velocity.magnitude < 0.1f) // 當球的速度接近零時，認為球停止了
        {
            isMoving = false;

            // 計算球距離圓心的距離
            double distanceFromCenter = Vector3.Distance(initialPosition, transform.position);

            // 檢查距離並觸發相應的事件
            if (distanceFromCenter < firstCircleRadius)
            {
                OnBallStopAtFirstCircle.Invoke(distanceFromCenter);
            }
            else if (distanceFromCenter < secondCircleRadius)
            {
                OnBallStopAtSecondCircle.Invoke(distanceFromCenter);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // 當球碰到其他物體時認為球在移動
        isMoving = true;
    }
}
