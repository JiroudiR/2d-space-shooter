using UnityEngine;

public class LeftBarrier : MonoBehaviour
{
    private bool enemiesMissed = false;
    public LeftBarrier(bool enemiesMissed)
    {
        this.enemiesMissed = enemiesMissed;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(enemiesMissed);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            enemiesMissed = true;
            Debug.Log(enemiesMissed);
        }        
    }
}
