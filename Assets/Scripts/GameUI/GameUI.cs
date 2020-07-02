using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    [Header("GameUI References")]
    [SerializeField] private TextMeshProUGUI _playerHealth;
    [SerializeField] private TextMeshProUGUI _numberOfEnemies;

    [Header("Prefabs References")]
    [SerializeField] private Health _player = new Health();
    

    void Update()
    {
        _playerHealth.text = "Player HP: " + (_player != null ? _player.health + "" : "_player in GameUI is null"); //edit: checks to make sure the player isn't null when we update the player health text 
        _numberOfEnemies.text = "Enemies: " + NumberOfZombies.EnemiesInScene;
    }
}