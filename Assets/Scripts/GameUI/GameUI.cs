using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    [Header("GameUI References")]
    [SerializeField] private TextMeshProUGUI _playerHealth;
    [SerializeField] private TextMeshProUGUI _numberOfEnemies;
    
    //Instantiating Custom Classes
    private PlayerLife _player = new PlayerLife();
    private Enemies _enemies = new Enemies();


    void Update()
    {
        _playerHealth.text = "Player HP: " + _player.HP.ToString();
        _numberOfEnemies.text = "Enemies Left: " + _enemies.EnemiesOnScene().ToString();
    }
}


public class PlayerLife
{
    public int HP = 3;
}


public class Enemies
{
    public int EnemiesOnScene() //Finds all game objects with tag "Enemy" int the scene.
    {
        int enemiesOnScene = GameObject.FindGameObjectsWithTag("Enemy").Length;
        return enemiesOnScene;
    }
}