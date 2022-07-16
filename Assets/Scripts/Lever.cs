using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// レバーのコンポーネント
/// クリックされるとレバーを回し、GachaManagerの_leverClickeをtrueにする
/// 排出されたガチャの演出が終わるまでは回せない
/// </summary>
public class Lever : MonoBehaviour, IPointerClickHandler
{
    /// <summary>ガチャを回せるか</summary>
    [SerializeField] bool _canPlayGacha = true;

    /// <summary>レバーを回すか</summary>
    [SerializeField] bool _doLeverRotate;

    /// <summary>レバーを回す時間</summary>
    [SerializeField] float _leverTime;

    /// <summary>レバーを回す速さ</summary>
    [SerializeField] float _leverSpeed = 2;

    /// <summary>レバーを次に回すまでの時間</summary>
    [SerializeField] float _betweenleverTime;

    /// <summary>一度押したら何回回す演出を行うか</summary>
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
    /// レバーがクリックされたときのメソッド
    /// 回している間はクリックしても反応しない
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
    /// レバーを指定した時間,指定した回数回す
    /// 回し終わったら再び回せるようにする
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
