using System;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class CollisionEventHandler : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    
    public Action<GameObject> OnEnter;
    public Action<GameObject> OnExit;
    public Action<GameObject> OnStay;

    public LayerMask LayerMask
    {
        get => layerMask;
        set => layerMask = value;
    }
    
    
    private void OnCollisionEnter(Collision other)
    {
        if (IsMasked(other.gameObject))
        {
            OnEnter?.Invoke(other.gameObject);
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (IsMasked(other.gameObject))
        {
            OnExit?.Invoke(other.gameObject);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (IsMasked(other.gameObject))
        {
            OnStay?.Invoke(other.gameObject);
        }
    }

    private bool IsMasked(GameObject gameObject) => (gameObject.layer & layerMask.value) > 0;
}
