using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] GameObject ScoreManager;
    public float mainHealth;
    public float maxHealth;
    private Score score;
    public GameObject healthBarUI;
    public Slider slider;

    private void Start()
    {
        mainHealth = maxHealth;
        HealthChange();
        score = ScoreManager.GetComponent<Score>();
    }

    private void Update()
    {
        HealthChange();
    }

    public void HealthChange()
    {
        slider.value = mainHealth;

        if (mainHealth < maxHealth)
        {
            healthBarUI.SetActive(true);
        }
        if (mainHealth <= 0)
        {
            score.addScore(1);
            Destroy(gameObject);
        }

    }

    

}
