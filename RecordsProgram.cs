class RecordDetails
{
	public string Name { get; set; }
	public string Artist { get; set; }
}

class Program : RecordDetails
{	
	static void Main()
	{
		Console.WriteLine("How many records do you want to add? ");
		var numberOfRecords = int.Parse(Console.ReadLine());

		var recordList = new List<RecordDetails>();

		for (int i = 0; i < numberOfRecords; i++)
		{
			// In this loop, populate the object's properties using Console.ReadLine()
			var recordDetails = new RecordDetails();
    	
			Console.WriteLine("Name of record?");
			recordDetails.Name = Console.ReadLine();

			Console.WriteLine("Name of artist?");
			recordDetails.Artist = Console.ReadLine();

			recordList.Add(recordDetails);
		}	

		// Print out the list of records using Console.WriteLine()
		Console.WriteLine("\nHere is a list of your records:");
        foreach (var recordDetails in recordList)
        {
            Console.WriteLine($"Name: {recordDetails.Name}, Artist: {recordDetails.Artist}");
        }
	}
}