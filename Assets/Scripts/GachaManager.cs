using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �K�`���̃}�l�[�W���[�R���|�[�l���g
/// �K�`���̃V�[���ɂȂ������ォ��K�`���𐶐�����
/// lever�I�u�W�F�N�g���N���b�N�����ƃK�`�����܂��
/// �r�o�����K�`���̓K�`�������̃o�[(UnderBar�I�u�W�F�N�g)�ɓ������Ă�����̂��烉���_���őI�΂��
/// </summary>
public class GachaManager : MonoBehaviour
{
    /// <summary>��������K�`���̃I�u�W�F�N�g</summary>
    [SerializeField] GameObject _gachaBallObj;

    /// <summary>�ŏ��ɐ�������K�`���̐�</summary>
    [SerializeField] int _gachaBallLimit = 10;

    /// <summary>�ŏ��ɐ�������K�`���̈ʒu</summary>
    [SerializeField] Vector2 InstantiatePoint;

    /// <summary>���o�[���񂳂ꂽ��true�ɂȂ�</summary>
    [SerializeField] bool _leverClicked;

    /// <summary>lever�I�u�W�F�N�g���g�p����v���p�e�B</summary>
    public bool Lever { get => _leverClicked; set => _leverClicked = value; }

    /// <summary>�o����I�u�W�F�N�g�̃��X�g
    /// UnderBar�I�u�W�F�N�g���ǂ݂��񂾂��̂������</summary>
    [SerializeField] List<GameObject> _waitToPullOut;

    /// <summary>lever�I�u�W�F�N�g���g�p����v���p�e�B</summary>
    public void PullOutObj(GameObject ball) { _waitToPullOut.Add(ball); }

    void Start()
    {
        //�V�[���ɓ������^�C�~���O�ŃK�`���ʂ�ݒ萔��������
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
    /// _lever���񂳂ꂽ�Ƃ��̃��\�b�h
    /// _waitToPullOut�̃��X�g���烉���_���Ŕr�o����
    /// </summary>
    void PlayGacha()
    {
        //���o�[���񂳂ꂽ��
        if (_leverClicked == true)
        {
            int Atari = Random.Range(0, _waitToPullOut.Count);

            //��������r�o�������̂̕\���A���o
            Debug.Log(_waitToPullOut[Atari].GetComponent<Ball1>().TestString);
            Destroy(_waitToPullOut[Atari]);

            //���X�g����r�o���ꂽ���̂�����
            _waitToPullOut.RemoveAt(Atari);
        }
        _leverClicked = false;
    }


}
