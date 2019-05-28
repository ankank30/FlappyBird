using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{

    public int columnPoolSize = 6;
    public GameObject columnPrefab;
    public float SpawnRate = 4f;
    public float ColumnMin = -1.5f;
    public float ColumnMax = 2.5f;

    private int currentColumn = 0;
    private float spawnXPosition = 12f;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private GameObject[] columns;
    private float timeSinceLastSpawned;

    // Use this for initialization
    void Start()
    {
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameController.instance.isDead == false && timeSinceLastSpawned >= SpawnRate)
        {
            timeSinceLastSpawned = 0f;
            float spawnYPosition = Random.Range(ColumnMin, ColumnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentColumn++;
            if (currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }

        }
    }
}
