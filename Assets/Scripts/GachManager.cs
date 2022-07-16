using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �K�`���̃}�l�[�W���[�R���|�[�l���g
/// �K�`���̃V�[���ɂȂ������ォ��K�`���𐶐�����
/// �r�o�����K�`���̓K�`�������̃o�[�ɓ������Ă�����̂��烉���_���őI�΂��
/// </summary>
public class GachManager : MonoBehaviour
{
    /// <summary>��������K�`���̃I�u�W�F�N�g</summary>
    [SerializeField] GameObject _gachaBallObj;

    /// <summary>�ŏ��ɐ�������K�`���̐�</summary>
    [SerializeField] int _gachaBallLimit = 10;

    /// <summary>�ŏ��ɐ�������K�`���̈ʒu</summary>
    [SerializeField] Vector2 InstantiatePoint;

    /// <summary>���o�[���񂳂ꂽ��true�ɂȂ�</summary>
    [SerializeField] bool _leverClicked;

    /// <summary>lever�I�u�W�F�N�g��true��Ԃ�</summary>
    public bool Lever { get => _leverClicked; set => _leverClicked = value; }

    /// <summary>�o����I�u�W�F�N�g�̃��X�g</summary>
    [SerializeField] List<GameObject> _waitToPullOut;

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
        if (_leverClicked == true)
        {
            int Atari = Random.Range(0, _waitToPullOut.Count);
            Debug.Log(_waitToPullOut[Atari].GetComponent<Ball1>().TestString);
            Destroy(_waitToPullOut[Atari]);
        }
        _leverClicked = false;
    }

    /// <summary>
    /// �K�`�������̃o�[�ɂӂ�Ă�����̂̃X�N���v�g�����X�g�ɓ���郁�\�b�h
    /// </summary>
    void ReadTochingToBarObj()
    {

    }

}
