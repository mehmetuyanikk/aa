using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRod : MonoBehaviour
{
    [SerializeField] GameObject _smallCircle;
    [SerializeField] Transform _spawnTransform;

    private void Update()
    {
        Spawner();
    }

    void Spawner()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_smallCircle, _spawnTransform.position, _spawnTransform.rotation);
        }
    }

}
