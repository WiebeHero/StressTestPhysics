using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnData", menuName = "ScriptableObjects/SpawnData", order = 1)]
public class SpawnData : ScriptableObject
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private int spawnCount;

    public GameObject Prefab => prefab;
    public int SpawnCount => spawnCount;
}
