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


void Query(string productName, decimal versionName, string status, string[] keywords)
{
	Tickets
		.Include(t => t.ProductVersionOperatingSystem)
			.ThenInclude(p => p.Product)
		.Include(t => t.ProductVersionOperatingSystem)
			.ThenInclude(p => p.Version)
		.Where(t => t.Status == status)
		.Where(t => t.ProductVersionOperatingSystem.Product.Name == productName)
		.Where(t => t.ProductVersionOperatingSystem.Version.Name == versionName)
		.Where(t => keywords.Length == 0 || keywords.All(keyword => t.Problem.ToLower().Contains(keyword.ToLower())))
		.Take(20).Dump();
}


// Obtenir tous les problèmes en cours pour un produit (une seule version)
Query("Planificateur d’Entraînement", 1.1m, "Pending", []);

// Obtenir tous les problèmes en cours pour un produit contenant une liste de mots-clés (une seule version)
Query("Planificateur d’Entraînement", 1.1m, "Pending", ["application", "connexion"]);

// Obtenir tous les problèmes résolus pour un produit (une seule version)
Query("Planificateur d’Entraînement", 1.1m, "Resolved", []);

// Obtenir tous les problèmes résolus pour un produit contenant une liste de mots-clés (une seule version)
Query("Planificateur d’Entraînement", 1.1m, "Resolved", ["message", "erreur"]);
