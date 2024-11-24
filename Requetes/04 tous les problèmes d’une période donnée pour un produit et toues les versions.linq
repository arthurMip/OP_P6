<Query Kind="Statements">
  <Connection>
    <ID>0417e005-0181-4b1c-8583-f2b09dbf8766</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Server>(localdb)\MSSQLLocalDB</Server>
    <Database>OP_P6</Database>
    <DisplayName>OP_P6</DisplayName>
    <DriverData>
      <EncryptSqlTraffic>True</EncryptSqlTraffic>
      <PreserveNumeric1>True</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>


void Query(string productName, string status, string[] keywords, DateTime startDate, DateTime endDate)
{
	Tickets
		.Include(t => t.ProductVersionOperatingSystem)
			.ThenInclude(p => p.Product)
		.Where(t => t.ProductVersionOperatingSystem.Product.Name == productName)
		.Where(t => (status == "Pending" && t.Created >= startDate && t.Created <= endDate) || 
					(status == "Resolved" && t.Resolved >= startDate && t.Resolved <= endDate))
		.Where(t => keywords.Length == 0 || keywords.All(keyword => t.Problem.ToLower().Contains(keyword.ToLower())))
		.Where(t => t.Status == status)
		.Take(20).Dump();
}

var startDate = new DateTime(2024, 1, 1);
var endDate = new DateTime(2024, 1, 25);

// Obtenir tous les problèmes rencontrés au cours d’une période donnée pour un produit (toutes les versions)
Query("Trader en Herbe", "Pending", [], startDate, endDate);

//Obtenir tous les problèmes rencontrés au cours d’une période donnée pour un produit contenant une liste de mots-clés (toutes les versions)
Query("Trader en Herbe", "Pending", ["compatible"], startDate, endDate);

startDate = new DateTime(2024, 2, 1);
endDate = new DateTime(2024, 2, 25);

// Obtenir tous les problèmes résolus au cours d’une période donnée pour un produit (toutes les versions)
Query("Trader en Herbe", "Resolved", [], startDate, endDate);

// Obtenir tous les problèmes résolus au cours d’une période donnée pour un produit contenant une liste de mots-clés (toutes les versions)
Query("Trader en Herbe", "Resolved", ["application", "Android"], startDate, endDate);
