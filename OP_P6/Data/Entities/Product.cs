namespace OP_P6.Data.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Version> Versions { get; set; } = [];
}

public class Version
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<OperatingSystem> OperatingSystems { get; set; } = [];
    public List<Ticket> Tickets { get; set; } = [];
}


public class OperatingSystem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Version> Versions { get; set; } = [];
    public List<Ticket> Tickets { get; set; } = [];
}

public class Ticket
{
    public int Id { get; set; }
    public int VersionId { get; set; }
    public Version? Version { get; set; }
    public int OperatingSystemId { get; set; }
    public OperatingSystem? OperatingSystem { get; set; }
    public DateTime Created { get; set; }
    public DateTime Resolved { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Problem { get; set; } = string.Empty;
    public string Solution { get; set; } = string.Empty;
}
