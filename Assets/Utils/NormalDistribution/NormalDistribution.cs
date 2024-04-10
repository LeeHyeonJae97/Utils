using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalDistribution : MonoBehaviour
{
    [SerializeField] private int _count;
    [SerializeField] private float _mean;
    [SerializeField] private float _sd;

    private List<Vector2> _points;

    private void Update()
    {
        UniformDistribution();
        NormalDistribution();

        void UniformDistribution()
        {
            if (Input.GetKeyDown(KeyCode.U))
            {
                _points = new List<Vector2>();

                for (int i = 0; i < _count; i++)
                {
                    var point = Random.insideUnitCircle;

                    _points.Add(point);
                }
            }
        }

        void NormalDistribution()
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                _points = new List<Vector2>();

                for (int i = 0; i < _count; i++)
                {
                    var point = ToNormalDistribution(_mean, _sd);

                    _points.Add(point);
                }
            }

            Vector2 ToNormalDistribution(float mean, float sd)
            {
                var point = Random.insideUnitCircle;
                var sqrDst = point.sqrMagnitude;

                var v = Mathf.Sqrt((-2 * Mathf.Log(sqrDst)) / sqrDst);

                return Vector2.one * mean + point * v * sd;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(Vector3.zero, 1f);

        if (_points != null)
        {
            foreach (var point in _points)
            {
                Gizmos.DrawWireSphere(point, .03f);
            }
        }
    }
}
