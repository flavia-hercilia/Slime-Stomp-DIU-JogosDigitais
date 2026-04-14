using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject slimePrefab;
    public float tempoEntreSpawns = 3f;

    void Start()
    {
        InvokeRepeating("SpawnSlime", 1f, tempoEntreSpawns);
    }

    void SpawnSlime()
    {
        if (slimePrefab != null)
        {
            Instantiate(slimePrefab, transform.position, Quaternion.identity);
        }
    }

}