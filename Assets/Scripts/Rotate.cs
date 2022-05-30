using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] int _childCount = 0, _level;
    [SerializeField] Text _levelText;
    [SerializeField] GameObject _spawner, _background, _gameOverPanel;

    GameObject[] _child;

    private void Start()
    {
        _levelText.text = "1";
        _level = int.Parse(_levelText.text);
    }

    private void FixedUpdate()
    {
        this.transform.Rotate(0, 0, _speed * Time.deltaTime);
        DestroyChild();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rod"))
        {
            _childCount++;
        }
    }

    void DestroyChild()
    {

        if (_childCount == int.Parse(_levelText.text))
        {
            _childCount = 0;
            _level++;

            _levelText.text = _level.ToString();
            _speed += 0.5f;

            for (int i = 0; i <= 50; i++)
            {
                _child = GameObject.FindGameObjectsWithTag("Rod");
                Destroy(_child[i]);
            }
        }

        if (int.Parse(_levelText.text) == 10)
        {
            SceneManager.LoadScene(2);

            _spawner.GetComponent<SpawnRod>().enabled = false;
            GetComponent<Rotate>().enabled = false;

        }

    }
}
