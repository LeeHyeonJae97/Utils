using System;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Trigger2DEventHandler : MonoBehaviour
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (IsMasked(other.gameObject))
        {
            OnEnter?.Invoke(other.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (IsMasked(other.gameObject))
        {
            OnExit?.Invoke(other.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (IsMasked(other.gameObject))
        {
            OnStay?.Invoke(other.gameObject);
        }
    }

    private bool IsMasked(GameObject gameObject) => (gameObject.layer & _layerMask.value) > 0;
}
