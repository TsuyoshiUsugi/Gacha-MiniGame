using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ガチャのマネージャーコンポーネント
/// ガチャのシーンになった時上からガチャを生成する
/// 排出されるガチャはガチャ下部のバーに当たっているものからランダムで選ばれる
/// </summary>
public class GachManager : MonoBehaviour
{
    /// <summary>生成するガチャのオブジェクト</summary>
    [SerializeField] GameObject _gachaBallObj;

    /// <summary>最初に生成するガチャの数</summary>
    [SerializeField] int _gachaBallLimit = 10;

    /// <summary>最初に生成するガチャの位置</summary>
    [SerializeField] Vector2 InstantiatePoint;

    /// <summary>レバーが回されたらtrueになる</summary>
    [SerializeField] bool _leverClicked;

    /// <summary>leverオブジェクトがtrueを返す</summary>
    public bool Lever { get => _leverClicked; set => _leverClicked = value; }

    /// <summary>出せるオブジェクトのリスト</summary>
    [SerializeField] List<GameObject> _waitToPullOut;

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
        if (_leverClicked == true)
        {
            int Atari = Random.Range(0, _waitToPullOut.Count);
            Debug.Log(_waitToPullOut[Atari].GetComponent<Ball1>().TestString);
            Destroy(_waitToPullOut[Atari]);
        }
        _leverClicked = false;
    }

    /// <summary>
    /// ガチャ下部のバーにふれているもののスクリプトをリストに入れるメソッド
    /// </summary>
    void ReadTochingToBarObj()
    {

    }

}
