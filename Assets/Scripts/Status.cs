using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Status
{
    

    [SerializeField]private float _hp;//体力
    public float Hp
    {
        get { return _hp; }
        set { _hp = value; }
    }
    [SerializeField]private float _mp;//魔力
    public float Mp
    {
        get { return _mp; }
        set { _mp = value; }
    }
    [SerializeField]private float _autoHpHealPower;//体力自動回復
    public float AutoHpHealPower
    {
        get { return _autoHpHealPower; }
        set { _autoHpHealPower = value; }
    }
    [SerializeField]private float _autoMpHealPower;//魔力自動回復
    public float AutoMpHealPower
    {
        get { return _autoMpHealPower; }
        set { _autoMpHealPower = value; }
    }
    [SerializeField]private float _speed;//スピード
    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    [SerializeField]private float _evasion;//回避率
    public float Evasion
    {
        get { return _evasion; }
        set { _evasion = value; }
    }
    [SerializeField]private float _lucky;//運
    public float Lucky
    {
        get { return _lucky; }
        set { _lucky = value; }
    }
    [SerializeField]private float _physicalPower;//物理攻撃力
    public float PhysicalPower
    {
        get { return _physicalPower; }
        set { _physicalPower = value; }
    }
    [SerializeField]private float _magicPower;//魔力攻撃率
    public float MagicPower
    {
        get { return _magicPower; }
        set { _magicPower = value; }
    }
    [SerializeField]private float _physicalDefence;//物理防御力
    public float PhysicalDefence
    {
        get { return _physicalDefence; }
        set { _physicalDefence = value; }
    }
    [SerializeField]private float _magicalDefence;//魔力防御力
    public float MagicalDefence
    {
        get { return _magicalDefence; }
        set { _magicalDefence = value; }
    }
    [SerializeField]private float _exp;//経験値
    public float Exp
    {
        get { return _exp; }
        set { _exp = value; }
    } 
    

}
