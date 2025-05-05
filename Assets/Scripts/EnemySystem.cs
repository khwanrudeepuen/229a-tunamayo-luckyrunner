using UnityEngine;

public class EnemySystem : MonoBehaviour
{
    public float moveSpeed = 2f;           // ความเร็วในการเคลื่อนที่
    public Transform leftPoint;            // จุดซ้ายสุดที่ enemy จะไปถึง
    public Transform rightPoint;           // จุดขวาสุดที่ enemy จะไปถึง

    private bool movingRight = true;       // ทิศทางการเดิน

    void Start()
    {
        movingRight = false;

        if (transform.localScale.x > 0)
        {
            Flip();
        }
    }

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            if (transform.position.x >= rightPoint.position.x)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            if (transform.position.x <= leftPoint.position.x)
            {
                movingRight = true;
                Flip();
            }
        }
    }

    void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
