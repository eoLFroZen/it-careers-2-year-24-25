
using System.Text;
using D03P02;

string input;

ExtensionList<string> extensionList = new ExtensionList<string>();
StringBuilder builder = new StringBuilder();

while((input = Console.ReadLine()) != "END")
{
    List<string> inputArgs = input
        .Split()
        .ToList();

    string command = inputArgs[0];

    if(command == "Add")
    {
        string element = inputArgs[1];

        extensionList.Add(element);
    }
    else if(command == "Remove")
    {
        int index = int.Parse(inputArgs[1]);

        extensionList.Remove(index);
    }
    else if(command == "Contains")
    {
        string element = inputArgs[1];

        bool isContained = extensionList.Contains(element);

        builder.AppendLine(isContained ? "True" : "False");
    }
    else if(command == "Swap")
    {
        int index1 = int.Parse(inputArgs[1]);
        int index2 = int.Parse(inputArgs[2]);

        extensionList.Swap(index1, index2);
    }
    else if(command == "Greater")
    {
        string element = inputArgs[1];

        builder.AppendLine(extensionList.CountGreaterThan(element).ToString());
    }
    else if(command == "Max")
    {
        builder.AppendLine(extensionList.Max());
    }
    else if(command == "Min")
    {
        builder.AppendLine(extensionList.Min());
    }
    else if(command == "Print")
    {
        builder.AppendLine(extensionList.PrintStr());
    }
}

System.Console.WriteLine(builder.ToString());