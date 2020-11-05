using UnityEngine;

public class LookTarget : MonoBehaviour
{
    [SerializeField] private Transform m_Target;
    private Transform m_Transform;
    
    private void Awake()
    {
        /*
         * Little known fact: all of the component accessors in MonoBehaviour, things like transform,
         * renderer, and audio, are equivalent to their GetComponent(Transform) counterparts,
         * and they are actually a bit slow. GameObject.FindWithTag has been optimized,
         * but in some cases, for example, in inner loops, or on scripts that run on a lot of instances,
         * this script might be a bit slow.
         */
        m_Transform = transform;
    }

    private void FixedUpdate()
    {
        m_Transform.LookAt(m_Target);
    }
}
