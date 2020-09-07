using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    private TextMeshProUGUI healthText;
    GameSession gameSession;
    Player player;

    void Start()
    {
        healthText = GetComponent<TextMeshProUGUI>();
        player = FindObjectOfType<Player>();
        healthText.text = player.GetHealth().ToString();
    }

    public void UpdateHealt()
    {
        healthText.text = player.GetHealth().ToString();
    }
}
