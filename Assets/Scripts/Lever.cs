using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// ���o�[�̃R���|�[�l���g
/// �N���b�N�����ƃ��o�[���񂵁AGachaManager��_leverClicke��true�ɂ���
/// �r�o���ꂽ�K�`���̉��o���I���܂ł͉񂹂Ȃ�
/// </summary>
public class Lever : MonoBehaviour, IPointerClickHandler
{
    /// <summary>�K�`�����񂹂邩</summary>
    [SerializeField] bool _canPlayGacha = true;

    /// <summary>���o�[���񂷂�</summary>
    [SerializeField] bool _doLeverRotate;

    /// <summary>���o�[���񂷎���</summary>
    [SerializeField] float _leverTime;

    /// <summary>���o�[���񂷑���</summary>
    [SerializeField] float _leverSpeed = 2;

    /// <summary>���o�[�����ɉ񂷂܂ł̎���</summary>
    [SerializeField] float _betweenleverTime;

    /// <summary>��x�������牽��񂷉��o���s����</summary>
    [SerializeField] float _RotateLeverTimes;

    [SerializeField] GameObject _gachaManager;

    void Update()
    {
        if (_doLeverRotate == true)
        {
            transform.RotateAround(transform.position, Vector3.forward, _leverSpeed);
        }
    }

    /// <summary>
    /// ���o�[���N���b�N���ꂽ�Ƃ��̃��\�b�h
    /// �񂵂Ă���Ԃ̓N���b�N���Ă��������Ȃ�
    /// </summary>
    /// <param name="eventData"></param>
    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        if (_canPlayGacha == true)
        {
            _canPlayGacha = false;
            StartCoroutine(RotateLever());
        }

    }

    /// <summary>
    /// ���o�[���w�肵������,�w�肵���񐔉�
    /// �񂵏I�������Ăщ񂹂�悤�ɂ���
    /// </summary>
    /// <returns></returns>
    IEnumerator RotateLever()
    {
        for (int i = 0; i < _RotateLeverTimes; i++)
        {
            _doLeverRotate = true;
            yield return new WaitForSeconds(_leverTime);
            _doLeverRotate = false;
            yield return new WaitForSeconds(_betweenleverTime);
        }
        _gachaManager.GetComponent<GachaManager>().Lever = true;
        _canPlayGacha = true;
    }
}
