using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollector : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            //ScoreManager.instance.AddScore(coinValue);
            Destroy(other.gameObject);
        }
    }
}
