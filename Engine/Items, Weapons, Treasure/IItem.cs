namespace Engine.Items
{
    public interface IItem
    {
        string Description { get; set; }
        bool Equip { get; set; }
        int ID { get; set; }
        string Name { get; set; }
        string PluralName { get; set; }

    }
}