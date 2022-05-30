using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    [SerializeField] GameObject _background, _gameOverPanel, _spawner, _levelText;

    private void FixedUpdate()
    {
        GameOver();
    }

    void GameOver()
    {
        if (_background.GetComponent<SpriteRenderer>().color == Color.red)
        {
            _levelText.SetActive(false);

            _gameOverPanel.SetActive(true);

            _spawner.GetComponent<SpawnRod>().enabled = false;
            GetComponent<Rotate>().enabled = false;
        }
    }

}
