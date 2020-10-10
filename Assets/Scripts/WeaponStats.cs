public interface WeaponStats {
    
    string Name { get; set; }
    int BaseDamage { get; set; }
    float DamageModifier { get; set; }
    float Speed { get; set; }
    int Strength { get; set; }
    int Dex { get; set; }
    int Intelligence { get; set; }
    int Rarity { get; set; }
    int LowEndDamage { get; set; }
    int HighEndDamage { get; set; }
}
