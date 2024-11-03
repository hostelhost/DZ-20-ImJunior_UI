using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    [SerializeField] private Vector3 direction = Vector3.up;

    private void Update()
    {
        transform.Rotate(_speed * Time.deltaTime * direction);
    }
}
