using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] private float _speed = 3f;
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private GameObject _canvas;
    [SerializeField] private GameObject _enemy1;
    [SerializeField] private GameObject _enemy2;
    [SerializeField] private GameObject _enemy3;

    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    private Animator _anime;

    // Start is called before the first frame update
    void Start()
    {
        
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _anime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float movement = Input.GetAxis("Horizontal");

        if(movement != 0)
        {
            transform.position += new Vector3(movement, 0, 0) * _speed * Time.deltaTime;
            _anime.SetBool("isRunning", true);
        }
        else
        {
            _anime.SetBool("isRunning", false);
        }
       

        if ((Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(_rb.velocity.y) < 1f))
        {
            _rb.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
            _anime.SetTrigger("Jump");
        }

        _sr.flipX = movement < 0 ? true : false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "enemy")
        {
            _canvas.SetActive(true);
        }
    }

}
