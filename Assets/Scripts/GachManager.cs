using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �K�`���̃}�l�[�W���[�R���|�[�l���g
/// �K�`���̃V�[���ɂȂ������ォ��K�`���𐶐�����
/// </summary>
public class GachManager : MonoBehaviour
{
    /// <summary>��������K�`���̃I�u�W�F�N�g</summary>
    [SerializeField] GameObject _gachaBallObj;

    /// <summary>�ŏ��ɐ�������K�`���̐�</summary>
    [SerializeField] int _gachaBallLimit = 10;

    /// <summary>�ŏ��ɐ�������K�`���̈ʒu</summary>
    [SerializeField] Vector2 InstantiatePoint;


    void Start()
    {
        //�V�[���ɓ������^�C�~���O�ŃK�`���ʂ𐶐�����
        for (int ballNumber = 0; ballNumber < _gachaBallLimit; ballNumber++)
        {
            InstantiateGacha();
        }
    }

    // Update is called once per frame
    void Update()
    {
        PlayGacha();
    }

    /// <summary>
    /// �K�`���ʂ𐶐����郁�\�b�h
    /// </summary>
    void InstantiateGacha()
    {
        Instantiate(_gachaBallObj, InstantiatePoint, Quaternion.identity);
    }

    /// <summary>
    /// �K�`�����񂷃��\�b�h
    /// </summary>
    void PlayGacha()
    {
        //if ()
    }
}
