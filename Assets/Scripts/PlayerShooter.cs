using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootPoint;
    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //  คลิกซ้ายเพื่อยิง
        {
            GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.linearVelocity = Vector2.right * bulletSpeed; // กระสุนวิ่งไปทางขวา
        }
    }
}
