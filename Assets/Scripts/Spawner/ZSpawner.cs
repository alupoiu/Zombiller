using UnityEngine;
using System.Collections;

public class ZSpawner : MonoBehaviour
{
    [Header("Spawn System")]

    [Tooltip("Place the Zombie Prefab Here")]
    [SerializeField] private GameObject _zombie;
    [SerializeField] private Transform pla;

    [Tooltip("The lower the Spawn Rate value, the fastest")]
    [SerializeField] private float _spawnRate = 1;

    //Claculation Variables
    private int limitOfZombiesOnScene;
    private bool spawnerIsActive = true;

    private void Start()
    {
        StartCoroutine(Spawner());    
    }

    IEnumerator Spawner()
    {
        while (spawnerIsActive)
        {
            yield return new WaitForSeconds(_spawnRate);
            int ScreenSize = 4;
            Vector2 randomPositionY = new Vector2(transform.position.x, Random.Range(ScreenSize, -ScreenSize));
            Instantiate(_zombie, randomPositionY, _zombie.transform.rotation);
        }
        
    }
}
