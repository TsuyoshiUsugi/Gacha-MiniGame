using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    /// Ball1�̃X�N���v�^�u���I�u�W�F�N�g����f�[�^��ǂݎ��
    /// </summary>
    void ItemData()
    {
        Ball1 ball1 = Resources.Load("Ball1") as Ball1;
        _testText = ball1.TestString;
    }
}