using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BoxSettings", menuName = "ScriptableObjects/BoxSettings", order = 0)]
public class BoxSettings : ScriptableObject
{
    [SerializeField] private bool performMove;
}
