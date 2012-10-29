<Query Kind="Expression">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

from c in Customers
join p in Purchases on c.ID equals p.CustomerID           // first join
join pi in PurchaseItems on p.ID equals pi.PurchaseID     // second join
select new
{
	c.Name, p.Description, pi.Detail
}