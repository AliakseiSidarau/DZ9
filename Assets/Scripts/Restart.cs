using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _enemy1;
    [SerializeField] private GameObject _enemy2;
    [SerializeField] private GameObject _enemy3;
    [SerializeField] private Button _restart;
    [SerializeField] private GameObject _krug;
    [SerializeField] private GameObject _balka1;
    [SerializeField] private GameObject _balka2;
    [SerializeField] private GameObject _balka3;
    [SerializeField] private Vector3 _startPointPlayer;
    [SerializeField] private Vector3 _startPointEnemy1;
    [SerializeField] private Vector3 _startPointEnemy2;
    [SerializeField] private Vector3 _startPointEnemy3;
    [SerializeField] private Vector3 _krugSatrt;

    private Vector3 startPos;

    void Start()
    {
        _restart.onClick.AddListener(Reload);
    }

    void Reload()
    {

        _player.transform.position = _startPointPlayer;
        _enemy1.transform.position = _startPointEnemy1;
        _enemy2.transform.position = _startPointEnemy2;
        _enemy3.transform.position = _startPointEnemy3;
        _krug.transform.position = _krugSatrt;
        _balka1.transform.rotation = Quaternion.identity;
        _balka2.transform.rotation = Quaternion.identity;
        _balka3.transform.rotation = Quaternion.identity;


        gameObject.SetActive(false);
    }
}
