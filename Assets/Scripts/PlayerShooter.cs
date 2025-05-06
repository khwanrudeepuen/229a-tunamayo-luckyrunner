using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float projectileSpeed = 10f;


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //  คลิกซ้ายเพื่อยิง
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0f;

            // คำนวณทิศทางจากจุดยิงไปยังเมาส์
            Vector2 direction = (mousePos - shootPoint.position).normalized;

            // สร้างกระสุน
            GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
            Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
            rb.velocity = direction * projectileSpeed;
        }
    }
}
