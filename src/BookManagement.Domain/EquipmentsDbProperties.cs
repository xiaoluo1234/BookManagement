namespace BookManagement;

public static class EquipmentsDbProperties
{
    public static string DbTablePrefix { get; set; } = "";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Equipments";
}
