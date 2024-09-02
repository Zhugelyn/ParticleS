using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private BulletPool _bulletPool;
    [SerializeField] private Transform _bulletSpawnPositon;

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = _bulletPool.GetBullet();
            bullet.Init(_bulletSpawnPositon.position, transform.forward);
        }
    }
}
