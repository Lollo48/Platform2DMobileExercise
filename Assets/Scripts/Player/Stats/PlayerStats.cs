using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerStats : BaseStats
{
    PlayerController _playerController;

    public PlayerStats(PlayerController playerController)
    {
        _playerController = playerController;
        _playerController.data.HP = _playerController.data.MaxHP;
        ActionManager.OnhealtRecharge += UpdateHealtPoint;
        ActionManager.OnHitUpdate += GetDamage;
    }

    protected override void GetDamage(float damage)
    {
        if (_playerController.data.HP <= 0) return;
        _playerController.data.HP -= damage;
    }

    protected override float GetDefaultHealtPoint() => _playerController.data.HP = _playerController.data.MaxHP;


    protected override float GetHealtPoint()=> _playerController.data.HP;


    protected override void UpdateHealtPoint(float pointToAdd)
    {
        if (_playerController.data.HP == _playerController.data.MaxHP) _playerController.data.HP = _playerController.data.MaxHP;
        _playerController.data.HP += pointToAdd;
    }
}
