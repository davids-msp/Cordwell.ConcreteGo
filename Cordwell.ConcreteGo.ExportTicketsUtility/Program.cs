using Cordwell.ConcreteGo.API.Connector;
using Cordwell.ConcreteGo.ExportTicketsUtility;
using CsvHelper;
using System.Globalization;

var appId = "";
var appKey = "";
var apiUrl = "http://hallett.api.concretego.com/webcreteapi.asmx"; 
var user = "user@hallett.com.au";
var pass = "";

Console.WriteLine("Starting export.");

var start = new DateTime(2023, 10, 5);
var end = new DateTime(2023, 10, 5);

var cgConnector = new CGAPIConnector(appId, appKey, user, pass, apiUrl);
await cgConnector.LoginAsync();

var tickets = await cgConnector.ListTicketsByOrderDateAsync(start, end);

var runData = await Processor.ConvertCGTicketsToRunData(tickets, cgConnector);

using (var writer = new StreamWriter(@"Exported Tickets " + start.ToString("dd-MM-yyyy") + " to " + end.ToString("dd-MM-yyyy") + ".csv"))
using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
{
    csv.WriteRecords(runData);
}

await cgConnector.LogoutAsync();

Console.WriteLine("Done.");
