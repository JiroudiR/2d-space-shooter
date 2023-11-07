using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftBarrier : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameManager manager = FindObjectOfType<GameManager>();
            manager.EnemyMissed();
        }        
    }
}
