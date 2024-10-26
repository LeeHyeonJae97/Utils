using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TriggerEventHandler : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;

    public event Action<GameObject> OnEnter;
    public event Action<GameObject> OnExit;
    public event Action<GameObject> OnStay;

    public LayerMask LayerMask
    {
        get => _layerMask;
        set => _layerMask = value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsMasked(other.gameObject))
        {
            OnEnter?.Invoke(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsMasked(other.gameObject))
        {
            OnExit?.Invoke(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (IsMasked(other.gameObject))
        {
            OnStay?.Invoke(other.gameObject);
        }
    }

    private bool IsMasked(GameObject gameObject) => (gameObject.layer & _layerMask.value) > 0;
}
