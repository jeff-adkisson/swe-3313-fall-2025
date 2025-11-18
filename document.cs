using System;
using System.Threading.Tasks;

abstract class DocumentBase
{
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public string Title { get; set; }
    public string Author { get; set; }
    public string FileName { get; set; }
    private bool IsModified { get; set; }

    public bool Load(string fileName)
    {
        FileName = fileName;
        Console.WriteLine($"Loading '{fileName}'...");
        return true;
    }

    public bool Save(string fileName)
    {
        FileName = fileName;
        IsModified = false;
        Console.WriteLine($"Saved '{fileName}' successfully.");
        return true;
    }

    public bool Close()
    {
        Console.WriteLine($"Closed '{FileName}'.");
        return true;
    }

    public abstract Task Print();
}

class ReportDocument : DocumentBase
{
    public string Format { get; set; } = "PDF";
    public bool IsPortraitOrientation { get; set; } = true;

    public bool Generate()
    {
        Console.WriteLine($"Generating {Format} report...");
        return true;
    }

    private string GenerateHeader(string heading) => $"Header: {heading}";
    private string GenerateFooter(string footer) => $"Footer: {footer}";

    public override async Task Print()
    {
        Console.WriteLine($"Printing report '{Title}'...");
        await Task.Delay(1000);
        Console.WriteLine($"Report printed in {Format} format.");
    }
}

class SpreadsheetDocument : DocumentBase
{
    public string[] Worksheets { get; set; } = new string[] { "Sheet1", "Sheet2" };
    public string[] FormulaErrors { get; set; } = new string[0];

    public void Calculate()
    {
        Console.WriteLine("Calculating spreadsheet formulas...");
        FormulaErrors = new string[0];
        Console.WriteLine("Calculation complete. No errors found.");
    }

    public override async Task Print()
    {
        Console.WriteLine($"Printing spreadsheet '{Title}'...");
        await Task.Delay(800);
        Console.WriteLine("Spreadsheet printed successfully.");
    }
}

class PresentationDocument : DocumentBase
{
    public bool HasAnimations { get; set; } = true;

    public string Present()
    {
        string mode = HasAnimations ? "with animations" : "without animations";
        string viewer = $"Presenting '{Title}' ({mode})...";
        Console.WriteLine(viewer);
        return viewer;
    }

    public override async Task Print()
    {
        Console.WriteLine($"Printing presentation '{Title}'...");
        await Task.Delay(1200);
        Console.WriteLine("Presentation handouts printed successfully.");
    }
}

class Program
{
    static async Task Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nDocument Management System");
            Console.WriteLine("1. Report Document");
            Console.WriteLine("2. Spreadsheet Document");
            Console.WriteLine("3. Presentation Document");
            Console.WriteLine("4. Exit");
            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();

            DocumentBase document = null;

            switch (choice)
            {
                case "1":
                    document = new ReportDocument { Title = "Quarterly Report", Author = "Jeff Adkisson" };
                    await RunDocumentMenu(document);
                    break;
                case "2":
                    document = new SpreadsheetDocument { Title = "Financial Data", Author = "Jeff Adkisson" };
                    await RunDocumentMenu(document);
                    break;
                case "3":
                    document = new PresentationDocument { Title = "Product Launch", Author = "Jeff Adkisson" };
                    await RunDocumentMenu(document);
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine("\nExiting application...");
    }

    static async Task RunDocumentMenu(DocumentBase document)
    {
        bool back = false;

        while (!back)
        {
            Console.WriteLine($"\n{document.GetType().Name} Menu");
            Console.WriteLine($"Title: {document.Title}, Author: {document.Author}");
            Console.WriteLine("1. Load");
            Console.WriteLine("2. Save");
            Console.WriteLine("3. Print");
            Console.WriteLine("4. Close");

            if (document is ReportDocument)
                Console.WriteLine("5. Generate Report");
            else if (document is SpreadsheetDocument)
                Console.WriteLine("5. Calculate");
            else if (document is PresentationDocument)
                Console.WriteLine("5. Present");

            Console.WriteLine("6. Back to Main Menu");

            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    document.Load($"{document.Title}.file");
                    break;
                case "2":
                    document.Save($"{document.Title}_saved.file");
                    break;
                case "3":
                    await document.Print();
                    break;
                case "4":
                    document.Close();
                    break;
                case "5":
                    if (document is ReportDocument r) r.Generate();
                    else if (document is SpreadsheetDocument s) s.Calculate();
                    else if (document is PresentationDocument p) p.Present();
                    break;
                case "6":
                    back = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (!back)
            {
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}