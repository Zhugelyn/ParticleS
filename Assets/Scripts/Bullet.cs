using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private ParticleSystem _hitPrefab;

    private Rigidbody _rigidbody;

    private void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Vector3 posotion = contact.point;

        var hitVFX = Instantiate(_hitPrefab, posotion, Quaternion.identity);
        Destroy(hitVFX, hitVFX.main.duration);

        Destroy(gameObject);
    }

    public void Init(Vector3 spawnPosition, Vector3 direction)
    {
        transform.position = spawnPosition;
        transform.rotation = Quaternion.identity;
        _rigidbody = GetComponent<Rigidbody>();
        Force(direction);
    }

    private void Force(Vector3 direction)
    {
        _rigidbody.AddForce(direction * _force);
    }
}
