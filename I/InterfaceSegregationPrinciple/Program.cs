namespace InterfaceSegregationPrinciple;

class Program
{
    static FurnitureCataloge cataloge = new FurnitureCataloge();

    static void Main(string[] args)
    {
        createCouches();
        createTables();

        cataloge.ListAvailableTables();
        cataloge.ListAvailableCouches();
    }

    static void createCouches(){
        Couch leatherCouch = new Couch();
        Couch textileCouch = new Couch();

        leatherCouch.fabric = "leather";
        leatherCouch.style = "modern";
        leatherCouch.condition = "new";
        leatherCouch.color = "red";
        leatherCouch.SetDimensions(50,40,100);

        cataloge.AddCouch(leatherCouch);

        textileCouch.fabric = "textile";
        textileCouch.style = "vintage";
        textileCouch.condition = "used";
        textileCouch.color = "brown";
        textileCouch.SetDimensions(20,70,90);

        cataloge.AddCouch(textileCouch);
    }

    static void createTables(){
        Table woodTable = new Table();
        Table plasticTable = new Table();

        woodTable.material = "wood";
        woodTable.style = "rustic";
        woodTable.condition = "new";
        woodTable.color = "brown";
        woodTable.SetDimensions(10,10,50);

        cataloge.AddTable(woodTable);

        plasticTable.material = "plastic";
        plasticTable.style = "modern";
        plasticTable.condition = "new";
        plasticTable.color = "white";
        plasticTable.SetDimensions(30,80,90);

        cataloge.AddTable(plasticTable);
    }
}
