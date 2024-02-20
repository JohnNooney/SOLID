namespace InterfaceSegregationPrinciple;

class FurnitureCataloge
{
    private List<Couch> couches;
    private List<Table> tables;

    public FurnitureCataloge()
    {
        couches = new List<Couch>();
        tables = new List<Table>();
    }

    public void AddCouch(Couch couch)
    {
        couches.Add(couch);
    }

    public void AddTable(Table table)
    {
        tables.Add(table);
    }

    public void ListAvailableTables()
    {
        Console.WriteLine("Available Tables: ");
        foreach (Table table in tables)
        {
            Console.WriteLine($"{table.material} Table \n"
            + $"Color: {table.color} \n"
            + $"Style: {table.style} \n"
            + $"Condition: {table.condition} \n"
            + $"Dimensions: L{table.dimensions.length}cm W{table.dimensions.width}cm H{table.dimensions.height}cm \n"
            + $"Area: {table.dimensions.GetArea()}cm \n");
        }
    }

    public void ListAvailableCouches()
    {
        Console.WriteLine("Available Couches: ");
        foreach (Couch couch in couches)
        {
            Console.WriteLine($"{couch.fabric} Table \n"
            + $"Color: {couch.color} \n"
            + $"Style: {couch.style} \n"
            + $"Condition: {couch.condition} \n"
            + $"Dimensions: L{couch.dimensions.length}cm W{couch.dimensions.width}cm H{couch.dimensions.height}cm \n"
            + $"Area: {couch.dimensions.GetArea()}cm \n");
        }
    }
}
