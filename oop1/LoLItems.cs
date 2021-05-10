using System;

namespace oop1
{
    public delegate void ReturnMethod(object obj, int index);
    public class CreatorIndexAttribute : Attribute
    {
        public int Index;
    }

    [CreatorIndex(Index = 0)]
    [Serializable]
    public class BaseItem
    {
        public string Name = "";
        public string Description = "";
        public int Level = 0;
        public int Cost = 0;
        public bool Jungle = false;
    }

    [CreatorIndex(Index = 1)]
    [Serializable]
    public class SpeedItem : BaseItem
    {
        public int AttackSpeed = 0;
        public int CritChance = 0;
        public int MoveSpeed = 0;
    }

    [CreatorIndex(Index = 2)]
    [Serializable]
    public class DamageItem : BaseItem
    {
        public bool Active = false;
        public bool SlowEffect = false;
        public bool GrievousWounds = false;
    }

    [CreatorIndex(Index = 3)]
    [Serializable]
    public class ApItem : DamageItem
    {
        public int AbilityPower = 0;
        public int CooldownReduction = 0;
        public int Mana = 0;
    }

    [CreatorIndex(Index = 4)]
    [Serializable]
    public class AdItem : DamageItem
    {
        public int AttackDamage = 0;
        public int Lethality = 0;
        public int LifeSteal = 0;
    }

    [CreatorIndex(Index = 5)]
    [Serializable]
    public class TankItem : BaseItem
    {
        public int MagicResistance = 0;
        public int Armor = 0;
        public int Health = 0;
        public int Regen = 0;
        public PassiveEffect Passive;
    }

    [Serializable]
    public class PassiveEffect
    {
        public string Name = "";
        public string Description = "";
        public bool Unique = false;
    }
}
