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


void Query(string productName, string status, string[] keywords)
{
	Tickets
		.Include(t => t.ProductVersionOperatingSystem)
		.ThenInclude(p => p.Product)
		.Where(t => t.Status == status)
		.Where(t => t.ProductVersionOperatingSystem.Product.Name == productName)
		.Where(t => keywords.Length == 0 || keywords.All(keyword => t.Problem.ToLower().Contains(keyword.ToLower())))
		.Take(20).Dump();
}


// Obtenir tous les problèmes en cours pour un produit (toutes les versions)
Query("Maître des Investissements", "Pending", []);

// Obtenir tous les problèmes en cours pour un produit contenant une liste de mots-clés (toutes les versions)
Query("Maître des Investissements", "Pending", ["application", "iOS"]);

// Obtenir tous les problèmes résolus pour un produit (toutes les versions)
Query("Maître des Investissements", "Resolved", []);

// Obtenir tous les problèmes résolus pour un produit contenant une liste de mots-clés (toutes les versions)
Query("Maître des Investissements", "Resolved", ["message", "erreur"]);
