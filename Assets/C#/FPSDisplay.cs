using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text)), ExecuteAlways]
public class FPSDisplay : MonoBehaviour
{
    [SerializeField, TextArea]
    private string m_TextTemplate = "FPS: <color=#bbbb00>{0}</color>";
    private Text m_Text;
    private float m_NextSecond;
    private int m_FrameCount = 0;

    private void Awake()
    {
        m_Text = GetComponent<Text>();
    }

    void Update()
    {
        m_FrameCount++;
        if (Time.realtimeSinceStartup > m_NextSecond)
        {
            m_Text.text = string.Format(m_TextTemplate, m_FrameCount);
            m_FrameCount = 0;
            m_NextSecond = Time.realtimeSinceStartup + 1f;
        }
    }
}
