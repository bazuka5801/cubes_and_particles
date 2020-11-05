using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text)), ExecuteAlways]
public class UIDistanceBetween : MonoBehaviour
{
    [SerializeField] private Transform m_A;
    [SerializeField] private Transform m_B;
    [SerializeField, TextArea]
    private string m_TextTemplate = "Дистанция между <color=#dd0000>кубами</color>: <color=#00bb00>{0}</color>";

    
    private Text m_Text;
    
    private void Awake()
    {
        m_Text = GetComponent<Text>();
    }

    private void Update()
    {
        var distance = Vector3.Distance(m_A.position, m_B.position);
        m_Text.text = string.Format(m_TextTemplate, distance);
    }
}
