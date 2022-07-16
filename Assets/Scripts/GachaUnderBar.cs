using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 当たったガチャを排出可能オブジェクトとしてGachaManagerに伝える
/// </summary>
public class GachaUnderBar : MonoBehaviour
{
    [SerializeField] GameObject _gachaManager;

    /// <summary>
    /// バーに当たったボールをGachaManagerのリストに入れる
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _gachaManager.GetComponent<GachaManager>().PullOutObj(collision.gameObject);
    }

}
