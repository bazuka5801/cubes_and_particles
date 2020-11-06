using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class DistanceCalculator : MonoBehaviour
{
    [SerializeField] private Transform m_A, m_B;
    public float Distance = float.MaxValue;

    

#if UNITY_EDITOR
    private void Update()
    {
        // EXECUTE ALWAYS
        FixedUpdate();
    }
#endif
    
    private void FixedUpdate()
    {
        Distance = Vector3.Distance(m_A.position, m_B.position);
    }
}
