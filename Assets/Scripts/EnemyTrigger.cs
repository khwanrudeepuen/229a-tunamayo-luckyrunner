using UnityEngine;
using UnityEngine.SceneManagement; // ต้องมีเพื่อใช้ LoadScene

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] string sceneToLoad; // ชื่อ scene ที่จะโหลดเมื่อชน enemy

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    // หรือจะใช้ OnTriggerEnter2D ก็ได้ถ้าใช้ Trigger แทน Collider ปกติ
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
    */
}