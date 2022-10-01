using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 1f;

    [SerializeField] private Transform[] points;
    public int i;
    private Vector3 _endPoint;
    private SpriteRenderer _sr;

    void Start()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, _moveSpeed * Time.deltaTime);

        if(Vector2.Distance(transform.position, points[i].position) < 0.2f)
        {
            if(i > 0)
            {
                i = 0;
            }
            else
            {
                i = 1;
            }
        }
    }
}
