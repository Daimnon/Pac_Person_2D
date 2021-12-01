using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _rb;

    [SerializeField]
    private Vector2 _velocity;

    [SerializeField]
    private float _speed;
    // Update is called once per frame
    void Update()
    {
        _velocity = new Vector2(Input.GetAxisRaw("Horizontal") * _speed * Time.deltaTime, Input.GetAxisRaw("Vertical") * _speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        _rb.AddForce(_velocity, ForceMode2D.Force);
    }
}
