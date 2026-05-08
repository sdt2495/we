using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public int enemyAmount = 5;

    public float rangeX = 10f;
    public float rangeZ = 10f;

    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < enemyAmount; i++)
        {
            // Å‘å”‚ð’´‚¦‚Ä‚¢‚½‚ç¶¬‚µ‚È‚¢
            if (GameManager.enemyCount >= GameManager.Maxenemy)
                break;

            float x = Random.Range(-rangeX, rangeX);
            float z = Random.Range(-rangeZ, rangeZ);

            Vector3 pos = transform.position + new Vector3(x, 0.5f, z);

            Instantiate(enemyPrefab, pos, Quaternion.identity);

            GameManager.enemyCount++;
        }

    }


}
