using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public event Action Steps;
    
    [SerializeField] private float _forceMagnitude = 10f;
    
    private Rigidbody _rigidbody;
    private int _steps;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out var hitInfo))
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                var direction = (hitInfo.point - transform.position).normalized;
                _rigidbody.AddForce(direction * _forceMagnitude, ForceMode.Impulse);
                
                Steps?.Invoke();
            }
        }
    }
}
