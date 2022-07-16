using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ガチャの商品のコンポーネント
/// </summary>
[CreateAssetMenu]
public class Ball1 : ScriptableObject
{
    [SerializeField] string _testText = "これはテストテキストです";

    public string TestString { get => _testText; }
}
