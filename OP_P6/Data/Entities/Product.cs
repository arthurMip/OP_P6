using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OP_P6.Data.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class Version
{
    public int Id { get; set; }
    public decimal Name { get; set; }
}


public class OperatingSystem
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class ProductVersionOperatingSystem
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    public int VersionId { get; set; }
    public Version? Version { get; set; }
    public int OperatingSystemId { get; set; }
    public OperatingSystem? OperatingSystem { get; set; }
}

public class Ticket
{
    public int Id { get; set; }
    public int ProductVersionOperatingSystemId { get; set; }
    public ProductVersionOperatingSystem? ProductVersionOperatingSystem { get; set; }
    public DateTime Created { get; set; }
    public DateTime Resolved { get; set; } = DateTime.MaxValue;
    public string Status { get; set; } = string.Empty;
    public string Problem { get; set; } = string.Empty;
    public string Solution { get; set; } = string.Empty;
}
