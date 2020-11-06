using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text)), ExecuteAlways]
public class UIDistanceBetween : MonoBehaviour
{
    [SerializeField] private DistanceCalculator m_DistanceCalculator;
    [SerializeField, TextArea]
    private string m_TextTemplate = "Дистанция между <color=#dd0000>кубами</color>: <color=#00bb00>{0}</color>";

    
    private Text m_Text;
    
    private void Awake()
    {
        m_Text = GetComponent<Text>();
    }

    private void Update()
    {
        var distance = m_DistanceCalculator.Distance;
        m_Text.text = string.Format(m_TextTemplate, distance.ToString("F2"));
    }
}
