using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Collision2DEventHandler : MonoBehaviour
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
    
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (IsMasked(other.gameObject))
        {
            OnEnter?.Invoke(other.gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (IsMasked(other.gameObject))
        {
            OnExit?.Invoke(other.gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (IsMasked(other.gameObject))
        {
            OnStay?.Invoke(other.gameObject);
        }
    }

    private bool IsMasked(GameObject gameObject) => (gameObject.layer & layerMask.value) > 0;
}
