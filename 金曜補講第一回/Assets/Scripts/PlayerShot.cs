using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;

    public InputAction shootAction;

    void OnEnable()
    {
        shootAction.Enable();
    }

    void OnDisable()
    {
        shootAction.Disable();
    }

    void Update()
    {
        if (shootAction.WasPressedThisFrame())
        {
            Debug.Log("Shoot() が呼ばれた！");
            Shoot();
        }
    }

    void Shoot()
    {
        // 弾を生成
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Debug.Log("弾を生成しました！ 位置：" + firePoint.position);

        // Rigidbody を取得して前方向に飛ばす
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = firePoint.forward * bulletSpeed;  // ← これが正しい
    }
}
