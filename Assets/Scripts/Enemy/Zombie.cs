using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    //References
    [SerializeField] private float _zombieSpeed = 1;
    private Transform _player;
    private FollowPlayer _zombie = new FollowPlayer();
    private float distanceFromPlayer = .5f;

    private void OnEnable()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    void Update()
    {
        if (Vector2.Distance(transform.position,_player.position) > distanceFromPlayer)
        {
            transform.position = _zombie.StartFollowing(transform, _player, _zombieSpeed * Time.deltaTime);
        }
    }
}

class FollowPlayer //Handles the following of the player
{
    public Vector3 StartFollowing(Transform zombie, Transform player, float zombieSpeed)
    {
       Vector3 _follow = Vector2.MoveTowards(zombie.position, player.position, zombieSpeed);
        return _follow;
    }
}
