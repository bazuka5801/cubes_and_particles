using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class CubesDistanceActions : MonoBehaviour
    {
        [SerializeField] private DistanceCalculator m_DistanceCalculator;
        [SerializeField] private GameObject m_SpheresContainer;

        private void Update()
        {
            var spheresEnabled = m_DistanceCalculator.Distance < 2.0f;
            if (spheresEnabled != m_SpheresContainer.activeSelf)
                m_SpheresContainer.SetActive(spheresEnabled);

            if (m_DistanceCalculator.Distance < 1.0f)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
                