using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnInstances : MonoBehaviour
{
    [SerializeField] private List<SpawnData> data;
    private List<GameObject> _objects;
    private int _current = 0;
    private int _spawned = 0;

    private void Start()
    {
        _objects = new List<GameObject>();
        Debug.Log(data.Count);
        for (int i = 0; i < data.Count; i++)
        {
            SpawnData spawnData = data[i];
            for (int x = 0; x < spawnData.SpawnCount; x++)
            {
                _objects.Add(Instantiate(spawnData.Prefab, transform.position, transform.rotation, null));
            }
        }
    }
    private void Update()
    {
        /*int count = 0;
        for (int i = 0; i < _objects.Count; i++)
        {
            //Debug.Log(i);
            GameObject obj = _objects[i];
            //Debug.Log("PosMe: " + transform.position);
            //Debug.Log("PosOther: " +  obj.transform.position);
            //Debug.Log("Distance: " + (transform.position - obj.transform.position).sqrMagnitude);
            if ((transform.position - obj.transform.position).magnitude >= 10)
            {
                count++;
            }
        }*/
        //Debug.Log("Missing squares: " + count);
    }

    public List<GameObject> GetObjects()
    {
        return _objects;
    }
}
