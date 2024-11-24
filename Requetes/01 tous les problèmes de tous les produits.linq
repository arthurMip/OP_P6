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


void Query(string status, string[] keywords)
{
	Tickets
		.Where(t => t.Status == status)
		.Where(t => keywords.Length == 0 || keywords.All(keyword => t.Problem.ToLower().Contains(keyword.ToLower())))
		.Take(20).Dump();
}

// Obtenir tous les problèmes en cours (tous les produits)
Query("Pending", []);

// Obtenir tous les problèmes en cours contenant une liste de mots-clés (tous les produits)
Query("Pending", ["incompatibilité", "iOS"]);

// Obtenir tous les problèmes résolus (tous les produits)
Query("Resolved", []);

// Obtenir tous les problèmes résolus contenant une liste de mots-clés (tous les produits)
Query("Resolved", ["reçoit", "message"]);