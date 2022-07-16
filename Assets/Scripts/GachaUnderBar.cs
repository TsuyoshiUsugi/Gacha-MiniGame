using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���������K�`����r�o�\�I�u�W�F�N�g�Ƃ���GachaManager�ɓ`����
/// </summary>
public class GachaUnderBar : MonoBehaviour
{
    [SerializeField] GameObject _gachaManager;

    /// <summary>
    /// �o�[�ɓ��������{�[����GachaManager�̃��X�g�ɓ����
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _gachaManager.GetComponent<GachaManager>().PullOutObj(collision.gameObject);
    }

}
