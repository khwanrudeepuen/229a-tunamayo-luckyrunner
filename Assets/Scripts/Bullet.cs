using UnityEngine;

public class Bullet : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                Destroy(other.gameObject); // ทำลายศัตรู
                Destroy(gameObject);       // ทำลายกระสุน
            }
        }
}
