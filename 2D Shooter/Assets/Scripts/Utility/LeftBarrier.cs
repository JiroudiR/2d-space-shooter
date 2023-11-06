using UnityEngine;

public class LeftBarrier : MonoBehaviour
{
    private bool enemiesMissed = false;

    public LeftBarrier(bool enemiesMissed)
    {
        this.enemiesMissed = enemiesMissed;
    }

    public void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log(enemiesMissed);
        if (gameObject.GetComponent<Collider2D>().tag == "Enemy")
        {
            enemiesMissed = true;
            Debug.Log(enemiesMissed);
        }        
    }
}
