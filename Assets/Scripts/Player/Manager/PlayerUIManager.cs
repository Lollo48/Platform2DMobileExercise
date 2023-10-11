using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
public class PlayerUIManager 
{
    public Slider Slider;
    public TextMeshProUGUI Score;
    PlayerController _playerController;

    public TextMeshProUGUI Ammo;

    public PlayerUIManager(Slider slider, float maxHp, TextMeshProUGUI score, TextMeshProUGUI ammo, PlayerController playerController)
    {
        Slider = slider;
        Slider.maxValue = maxHp;
        Slider.value = Slider.maxValue;
        Score = score;
        Ammo = ammo;
        _playerController = playerController;
        ActionManager.OnUpdateScore += UpdateScore;
        ActionManager.OnhealtRecharge += UpdateHP;
        ActionManager.OnHitUpdate += UpdateHitDamage;
        ActionManager.OnUpdateAmmoCount += UpdateAmmoCount;
    }


    private void UpdateHP(float HPCost)
    {
        if (Slider.value == Slider.maxValue) return;
        Slider.value += HPCost;

    }


    private void UpdateScore(float score)
    {
        _playerController.data.ScorePoints += score; 
        Score.text = _playerController.data.ScorePoints.ToString();
    }

    private void UpdateHitDamage(float damage)
    {
        if (Slider.value <= 0) return;
        Slider.value -= damage;
    }

    private void UpdateAmmoCount()
    {
        if (_playerController.data.Ammo == 0) Ammo.text = 0.ToString();
         _playerController.data.Ammo -= 1;
        Ammo.text = _playerController.data.Ammo.ToString();
    }

}
