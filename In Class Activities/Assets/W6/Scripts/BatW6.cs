using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private Transform _player;

    private bool _isChasing = false;

    private void Update()
    {
        if (_isChasing)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);
        }
    }

    public void ChasePlayer()
    {
        _isChasing = true;
    }

    public void StopChasing()
    {
        _isChasing = false;
    }
}
