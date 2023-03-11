using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class BoxSettings : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpawnInstances _instances;
    private string assetPath = Application.streamingAssetsPath;
    private string[] totalData;
    private string[] frameData;
    private int current;

    private void Start()
    {
        totalData = new string[2000];
        frameData = new string[2000];
        StartCoroutine(StartAnimation());
        if (!Directory.Exists(assetPath))
            Directory.CreateDirectory(assetPath);
        File.Create(assetPath + "/AllData.txt");
        File.Create(assetPath + "/FrameData.txt");
    }
    
    private void OnDisable()
    {
        Debug.Log(totalData.Length);
        File.WriteAllLines(assetPath + "/AllData.txt", totalData);
        File.WriteAllLines(assetPath + "/FrameData.txt", frameData);
    }

    IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(0.5f);
        List<GameObject> objects = _instances.GetObjects();
        for (int i = 0; i < objects.Count; i++)
        {
            GameObject obj = objects[i].transform.GetChild(0).gameObject;
            Rigidbody rigid = obj.GetComponent<Rigidbody>();
            rigid.isKinematic = false;
            rigid.detectCollisions = true;
        }
        _animator.SetTrigger("MoveAndRotate");
    }

    void Update()
    {
        if (current >= totalData.Length)
            return;
        totalData[current] = "Frame: " + current + ", Time since last: " + Time.deltaTime;
        frameData[current] = Time.deltaTime + "";
        current++;
    }
    
}
