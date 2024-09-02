using UnityEngine;
using UnityEngine.Pool;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private Bullet _prefab;

    private ObjectPool<Bullet> Pool;
 
    private void Awake()
    {
        Pool = new ObjectPool<Bullet>
            (
                createFunc: () => Instantiate(_prefab)
            );
    }

    public Bullet GetBullet()
    {
        return Pool.Get();
    }
}
