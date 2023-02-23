using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnInstances : MonoBehaviour
{
    [SerializeField] private List<SpawnData> data;
    private int _current = 0;
    private int _spawned = 0;

    private void Start()
    {
        for (int i = 0; i < data.Count; i++)
        {
            SpawnData spawnData = data[i];
            for (int x = 0; x < spawnData.SpawnCount; x++)
            {
                Instantiate(spawnData.Prefab, transform.position, transform.rotation, null);
            }
        }
    }
    private void Update()
    {
        Debug.Log("Current FPS: " + 1.0f / Time.deltaTime + ", Current time: " + Time.time);
    }
}
