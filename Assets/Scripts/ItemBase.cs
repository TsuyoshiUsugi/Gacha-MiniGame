using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 排出されるアイテムのクラス
/// </summary>
public class ItemBase : MonoBehaviour
{
    /// <summary>scriptableObjectから読みこんだテキスト </summary>
    [SerializeField] string _testText;

    public string TestText { get => _testText; }
    // Start is called before the first frame update
    void Start()
    {
        ItemData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Ball1のスクリプタブルオブジェクトからデータを読み取る
    /// </summary>
    void ItemData()
    {
        Ball1 ball1 = Resources.Load("Ball1") as Ball1;
        _testText = ball1.TestString;
    }
}
