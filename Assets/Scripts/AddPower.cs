using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �K�`�����܂�Ȃ��悤�ɂ���R���|�[�l���g
/// </summary>
public class AddPower : MonoBehaviour
{
    /// <summary>�ǂ̂��炢�̗͂�^���邩���߂� </summary>
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
