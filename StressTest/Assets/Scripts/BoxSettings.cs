using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.Profiling;

public class BoxSettings : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpawnInstances _instances;
    [SerializeField] private int _sampleSize;
    [SerializeField] private string _animation;
    private string assetPath = Application.streamingAssetsPath;
    private string[] totalData;
    private string[] frameData;
    private int current;

    private long past;

    private void Start()
    {
        totalData = new string[_sampleSize];
        frameData = new string[_sampleSize];
        StartCoroutine(StartAnimation());
        if (!Directory.Exists(assetPath))
            Directory.CreateDirectory(assetPath);
        File.Create(assetPath + "/AllData.txt");
        File.Create(assetPath + "/FrameData.txt");
        past = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    }
    
    private void OnDisable()
    {
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
        _animator.SetTrigger(_animation);
    }

    void Update()
    {
        if (current >= _sampleSize)
            Application.Quit();
        long now = DateTimeOffset.Now.ToUnixTimeMilliseconds();
        long difference = now - past;
        past = now;
        totalData[current] = current + ", " + difference;
        frameData[current] = difference + "";
        current++;
    }
    
}
