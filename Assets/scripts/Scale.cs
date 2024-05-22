using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _size;

    void Update()
    {
        transform.localScale += new Vector3 (_size,_size,_size) * Time.deltaTime;
    }
}
