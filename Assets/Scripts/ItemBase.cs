using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

/// <summary>
/// �r�o�����A�C�e���̃N���X
/// </summary>
public class ItemBase : MonoBehaviour
{
    /// <summary>scriptableObject����ǂ݂��񂾃e�L�X�g </summary>
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
    /// Resources��ball1�̏���ǂݎ��
    /// </summary>
    void ItemData()
    {
        var ball1 = Resources.Load<Ball1>("Ball1");
        if (ball1 == null)
        {
            Debug.Log("aaaaa");
        }
        _testText = ball1.TestText;
    }
}
