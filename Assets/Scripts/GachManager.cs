using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ガチャのマネージャーコンポーネント
/// ガチャのシーンになった時上からガチャを生成する
/// </summary>
public class GachManager : MonoBehaviour
{
    /// <summary>生成するガチャのオブジェクト</summary>
    [SerializeField] GameObject _gachaBallObj;

    /// <summary>最初に生成するガチャの数</summary>
    [SerializeField] int _gachaBallLimit = 10;

    /// <summary>最初に生成するガチャの位置</summary>
    [SerializeField] Vector2 InstantiatePoint;


    void Start()
    {
        //シーンに入ったタイミングでガチャ玉を生成する
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
    /// ガチャ玉を生成するメソッド
    /// </summary>
    void InstantiateGacha()
    {
        Instantiate(_gachaBallObj, InstantiatePoint, Quaternion.identity);
    }

    /// <summary>
    /// ガチャを回すメソッド
    /// </summary>
    void PlayGacha()
    {
        //if ()
    }
}
