using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationBronze : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject _prefab;
    [SerializeField] Vector3 _position;

    void Start()
    {
        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f);
        Instantiate(_prefab, _position, _rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
