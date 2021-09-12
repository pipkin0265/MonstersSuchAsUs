namespace Engine.Items
{
    public interface IEquip
    {
        int WearLocation { get; set; }
        string Name { get; set; }
    }
}