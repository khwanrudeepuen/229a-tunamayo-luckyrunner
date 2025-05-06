using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)  // ← แก้จาก Collider เป็น Collider2D
    {
        if (other.CompareTag("Coin"))
        {
            ScoreManager.instance.AddScore(coinValue);
            Destroy(other.gameObject);
        }
    }
}