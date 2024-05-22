using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 1;

    private void Update()
    {
        transform.Rotate(new Vector3(0, _rotationSpeed, 0)* Time.deltaTime);
    }

}
