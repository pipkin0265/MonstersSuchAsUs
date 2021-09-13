namespace Engine
{
    public interface IWeapon
    {
        string Damage { get; set; }
        string DamageType { get; set; }
        string Description { get; set; }
        bool Equip { get; set; }
        int ID { get; set; }
        string Name { get; set; }
        string PluralName { get; set; }
        int WearLocation { get; set; }
    }
}