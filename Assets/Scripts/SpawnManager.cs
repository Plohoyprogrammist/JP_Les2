using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;

    private float _spawnRangeX = 20f;
    private float _spawnRangeZ = 20f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-_spawnRangeX, _spawnRangeX), 0, _spawnRangeZ);
            int animalIndex = Random.Range(0, animalPrefab.Length);
            Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
        }
    }

}
