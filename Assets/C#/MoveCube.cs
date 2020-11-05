using UnityEngine;

public class MoveCube : MonoBehaviour
{
    [SerializeField][Tooltip("WASD move keys")]
    private KeyCode[] moveKeys = new KeyCode[4];
    
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
    private void Update()
    {
        m_MoveVector = Vector3.zero;
        for (var i = 0; i < moveKeys.Length; i++)
        {
            if (Input.GetKey(moveKeys[i]))
                m_MoveVector += m_MoveVectors[i];
        }
    }
}
