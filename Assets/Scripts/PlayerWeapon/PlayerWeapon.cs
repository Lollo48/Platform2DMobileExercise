using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerWeapon : WeaponBase
{

    public List<GameObject> m_ObjectAvailable = new List<GameObject>();
    [SerializeField] private GameObject m_ObjectToPool;

    public Transform GunEnd;

    PlayerController _playerControler;

    private void Awake()
    {
        _playerControler = GetComponent<PlayerController>();
    }


    private void Start()
    {
        InitialGeneration(_playerControler.data.InitialAmmo);
    }

    public virtual void InitialGeneration(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            m_ObjectAvailable.Add((Instantiate(m_ObjectToPool, GunEnd.transform)));
            m_ObjectAvailable[i].SetActive(false);
        }
    }

    public GameObject GetObject()
    {
        GameObject go = m_ObjectAvailable[_playerControler.data.Ammo - 1];
        go.SetActive(true);
        return go;
    }

    public override void Shoot()
    {
        if (_playerControler.data.Ammo == 0) return;
        GameObject go = GetObject();
        go.transform.position = GunEnd.transform.position;
        ActionManager.OnUpdateAmmoCount?.Invoke();

    }

    public void Reload()
    {
        _playerControler.data.Ammo = _playerControler.data.InitialAmmo;
        _playerControler.Ammo.text = _playerControler.data.Ammo.ToString();
    }
  

}
