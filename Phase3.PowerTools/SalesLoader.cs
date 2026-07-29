namespace Phase3.PowerTools;

public static class SalesLoader
{
    public static List<Sale> LoadSales(string path)
    {
        List<Sale> sales = new List<Sale>();
        sales = File.ReadAllLines(path)
            .Skip(1) 
            .Select(line =>
            {
                var parts = line.Split(',');
                return new Sale(
                    parts[0],
                    parts[1],
                    decimal.Parse(parts[2]),
                    int.Parse(parts[3])
                );
            })
            .ToList();
            
        return sales;
    }
}