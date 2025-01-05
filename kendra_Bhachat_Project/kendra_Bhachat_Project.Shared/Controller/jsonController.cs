using System.Text.Json;
public class jsonController() 
{

    static string userfilename = "C:\\Users\\user\\source\\repos\\kendra_Bhachat_Project\\user.json";
    public static void AddDataToJSONFile(Users data)
    {
        string jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText(userfilename, jsonString);
        Console.WriteLine("Data saved to file.");
    }

    static string incomefile = "C:\\Users\\user\\source\\repos\\kendra_Bhachat_Project\\income.json";
    public static void AddDataToJSONFile(List<incomes> data)
    {
        string jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText(incomefile, jsonString);
        Console.WriteLine("Data saved to file.");
    }

    static string expensesfile = "C:\\Users\\user\\source\\repos\\kendra_Bhachat_Project\\expenditure.json";
    public static void AddDataToJSONFile(List<expenditure> data)
    {
        string jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText(expensesfile, jsonString);
        Console.WriteLine("Data saved to file.");
    }

    static string debtfile = "C:\\Users\\user\\source\\repos\\kendra_Bhachat_Project\\debt.json";
    public static void AddDataToJSONFile(List<debt> data)
    {
        string jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText(debtfile, jsonString);
        Console.WriteLine("Data saved to file.");

    }


    static string tagFile = "C:\\Users\\user\\source\\repos\\kendra_Bhachat_Project\\tag.json";
    public static void AddDataToJSONFile(List<tg> data)
    {
        string jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText(tagFile, jsonString);
        Console.WriteLine("Data saved to file.");
    }


    public static List<incomes> GetDataFromJsonFile()
    {
        string jsonFromFile = File.ReadAllText(incomefile);
        List<incomes> deserializedTransactionData = JsonSerializer.Deserialize<List<incomes>>(jsonFromFile);

        return deserializedTransactionData;
    }

    public static List<expenditure> GetDataFromJsonForExpensesFile()
    {
        string jsonFromFile = File.ReadAllText(expensesfile);
        List<expenditure> deserializedTransactionData = JsonSerializer.Deserialize<List<expenditure>>(jsonFromFile);

        return deserializedTransactionData;
    }

    public static List<debt> GetDataFromJsonForDebtFile()
    {
        string jsonFromFile = File.ReadAllText(debtfile);
        List<debt> deserializedTransactionData = JsonSerializer.Deserialize<List<debt>>(jsonFromFile);

        return deserializedTransactionData;
    }


    public static List<tg> GetDataFromJsonForTagFile()
    {
        string jsonFromFile = File.ReadAllText(tagFile);
        List<tg> deserializedTransactionData = JsonSerializer.Deserialize<List<tg>>(jsonFromFile);

        return deserializedTransactionData;
    }

    public static Users GetDataFromJsonForTagFileUser()
    {
        string jsonFromFile = File.ReadAllText(tagFile);
        Users deserializedTransactionData = JsonSerializer.Deserialize<Users>(jsonFromFile);

        return deserializedTransactionData;
    }

}

