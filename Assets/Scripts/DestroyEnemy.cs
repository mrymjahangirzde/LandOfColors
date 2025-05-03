using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public AudioSource DestroyEnemySound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DestroyEnemySound.Play();
            Enemy.SetActive(false);
        }
    }
}
