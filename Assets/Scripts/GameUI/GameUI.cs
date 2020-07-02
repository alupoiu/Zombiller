using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameUI : MonoBehaviour
{
    [Header("GameUI References")]
    [SerializeField] private TextMeshProUGUI _playerHealth;
    [SerializeField] private TextMeshProUGUI _numberOfEnemies;
    [SerializeField] private TextMeshProUGUI _playerAmmo;


    [Header("Prefabs References")]
    [SerializeField] private Health _player = new Health();

    [Header("Ammo Reference")]
    [SerializeField] private shooting ammo;
    

    void Update()
    {
        _playerHealth.text = "Player HP: " + (_player != null ? _player.health + "" : "_player in GameUI is null"); //edit: checks to make sure the player isn't null when we update the player health text 
        _numberOfEnemies.text = "Enemies: " + NumberOfZombies.EnemiesInScene;
        _playerAmmo.text = "Ammo: " + ammo.playerAmmo;
    }
}