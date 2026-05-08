using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target;   // Player の Transform
    public float speed = 3f;

    void Update()
    {
        if (target == null) return;

        // プレイヤーの方向を向く
        transform.LookAt(target);

        // プレイヤーへ向かって移動
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );
    }
}
