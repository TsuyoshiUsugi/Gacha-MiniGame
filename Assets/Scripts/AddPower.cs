using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ガチャがつまらないようにするコンポーネント
/// </summary>
public class AddPower : MonoBehaviour
{
    /// <summary>どのくらいの力を与えるかきめる </summary>
    [SerializeField] float _power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.rigidbody.AddForce(Vector3.right * _power, ForceMode.Impulse);
    }
}
