using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField, Tooltip("WASD move keys")]
    private KeyCode[] moveKeys = new KeyCode[4];
    
    [SerializeField, Range(0.1f, 1f)]
    private float m_Speed;
    
    private Vector3[] m_MoveVectors = 
    {
        // W - Up
        new Vector3(0,0,1), 
        // A - Left
        new Vector3(-1, 0,0),
        // S - Down
        new Vector3(0,0,-1),
        // D - Right
        new Vector3(1,0,0), 
    };

    private Vector3 m_MoveVector = Vector3.zero;
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

    private void Update()
    {
        m_MoveVector = Vector3.zero;
        for (var i = 0; i < moveKeys.Length; i++)
        {
            if (Input.GetKey(moveKeys[i]))
                m_MoveVector += m_MoveVectors[i];
        }
    }

    private void FixedUpdate()
    {
        m_Transform.position += m_MoveVector * (Time.fixedDeltaTime * m_Speed);
    }
}
