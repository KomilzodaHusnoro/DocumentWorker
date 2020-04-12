using System;

namespace Document_worker
{
    class Program
    {
        static void Main(string[] args)
        {
            ///System.Console.Write("*not everyone sees these passwords*\n #12345#  --> for pro version users\n#54321#  --> for expert version users");
            string passwordForExpert = "54321";
            string passwordForPro = "12345";
            System.Console.WriteLine("Imagine that you are working with a text editor and a window pops up...");
            System.Console.Write("Did you get the Expert version?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes"){
                ExpertDocumentWorker edw = new ExpertDocumentWorker();
                Console.Clear();
                Console.Write("Enter password:");
                string inputPasswordForExpert = Console.ReadLine();
                if (inputPasswordForExpert == passwordForExpert){
                    Console.Write("Now you can continue or work with new ability: \n*1* --> open document\n*2* --> edit document\n*3* -->save document in a new format\nYour choise: ");
                    int choise = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (choise)
                    {
                        case 1:
                        {
                            edw.OpenDocument();
                        }break;
                        case 2:
                        {
                            edw.EditDocument();
                        }break;
                        case 3:
                        {
                            edw.SaveDocument();
                        }break;
                    }
                }
            }
            if ( answer == "no"){
                System.Console.WriteLine("Update your text-redactor for more abilities.");
                Console.ReadKey();
                Console.Clear();
                System.Console.Write("Did you get the Pro version?");
                string answer2 = Console.ReadLine().ToLower();
                if (answer2 == "yes"){
                ProDocumentWorker pdw = new ProDocumentWorker();
                Console.Clear();
                Console.Write("Enter password:");
                string inputPasswordForExpert = Console.ReadLine();
                if (inputPasswordForExpert == passwordForPro){
                    Console.Write("Now you can continue or work with following ability: \n*1* --> open document\n*2* --> edit document\n*3* -->anyway save document in an old format\nYour choise: ");
                    int choise = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (choise)
                    {
                        case 1:
                        {
                            pdw.OpenDocument();
                        }break;
                        case 2:
                        {
                            pdw.EditDocument();
                        }break;
                        case 3:
                        {
                            pdw.SaveDocument();
                        }break;
                    }
                } 
            }

        }
    }
}

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            System.Console.WriteLine("Document is open");
        }
        public virtual void EditDocument()
        {
            System.Console.WriteLine("Document editing is available in the Pro version.");
        }
        public virtual void SaveDocument()
        {
            System.Console.WriteLine("Saving a document is available in the Pro version");
        }
    }
    class ProDocumentWorker:DocumentWorker
    {
        public override void EditDocument()
        {
            System.Console.WriteLine("Document edited");
        }
        public override void SaveDocument()
        {
            System.Console.WriteLine("The document is saved in the old format, saving in the restformats are available in the Expert version");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker 
    {
        public override void SaveDocument()
        {
            System.Console.WriteLine("Document saved in a new format");
        }
    }
}
