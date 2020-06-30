using UnityEngine;
using System.Collections;

public class ZSpawner : MonoBehaviour
{
    [Header("Spawn System")]

    [Tooltip("Place the Zombie Prefab Here")]
    [SerializeField] private GameObject _zombie;

    [Tooltip("The lower the Spawn Rate value, the fastest")]
    [SerializeField] private float _spawnRate = 1;

    private float _spawnStartDelay = 1.5f;


    void Start()
    {
        InvokeRepeating("ZombieSpawner", _spawnStartDelay, _spawnRate);
    }


    void ZombieSpawner() //Instantiate object with is current x axis but random y axis 
    {
        int ScreenCorner = 4;
        Vector2 randomPositionY = new Vector2(transform.position.x, Random.Range(ScreenCorner, -ScreenCorner));
        Instantiate(_zombie, randomPositionY, _zombie.transform.rotation);
    }
}
