using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �K�`���̏��i�̃R���|�[�l���g
/// </summary>
[CreateAssetMenu]
public class Ball1 : ScriptableObject
{
    [SerializeField] string _testText = "����̓e�X�g�e�L�X�g�ł�";

    public string TestString { get => _testText; }
}
