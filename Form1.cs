using Analiza.Button;
using Analiza.File;
using Analiza.SupportFunction;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Analiza
{
    public partial class Form1 : Form
    {
        string RedPath = null;
        string savePath = null;
        FunctionButton functionButton = new FunctionButton();
        FileSupport fileSupport = new FileSupport();
        FunkcjonSupport funkcjonSupport = new FunkcjonSupport();
        List<Code> PriperSymbols = new List<Code>();
        List<List<Code>> AllWordSelekted = new List<List<Code>>();
        public Form1()
        {
            InitializeComponent();
        }

        private void PathToFile_Click(object sender, EventArgs e)
        {
            var path = new OpenFileDialog();
            RedPath = functionButton.TakePathRead(path, Path);
        }
        private void PathToSave_Click(object sender, EventArgs e)
        {
            var path = new FolderBrowserDialog();
            savePath = functionButton.SelektFolder(path, SavePath);
        }

        private void LoadAndOpereitOnFile()
        {
            Shering.Shering shering = new Shering.Shering();
            List<OneLine> Lains = new List<OneLine>();


            if (functionButton.CheckPath(RedPath) == true)
            {
                string[] allLine = fileSupport.Read(RedPath);
                if(allLine==null)
                {
                    return;
                }
                for (int i = 1; i < allLine.Length; i++)
                {
                    OneLine oneLine = new OneLine();
                    shering.SheringLine(oneLine, allLine[i]);
                    Lains.Add(oneLine);
                }
                PriperSymbols = shering.selecktInformacionInLine(Lains);
                allLine = null;
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Sumary.Items.Clear();
            LoadAndOpereitOnFile();
            AllWordSelekted = new List<List<Code>>();
            if(PriperSymbols.Count==0)
            {
                return;
            }
            if (int.TryParse(HowMenyChar.Text,out int HowMenyCharInt))
            {
                
            }
            else
            {
                MessageBox.Show("Minimalna długość wiadomosci musi być liczbą dodatniom ");
            }
            if (int.TryParse(HowMenyResult.Text, out int HowMenyResultInt))
            {

            }
            else
            {
                MessageBox.Show("Ilość wyników musi być liczbą całkowitą");
            }
            if (int.TryParse(MinRedudation.Text, out int MinRedudationInt))
            {

            }
            else
            {
                MessageBox.Show("Ilość wyników musi być liczbą całkowitą");
            }
            if (PriperSymbols.Count>0 && HowMenyCharInt>1 && HowMenyResultInt>0 && MinRedudationInt>1)
            {

                Shering.Shering shering = new Shering.Shering();

                for (HowMenyCharInt= HowMenyCharInt; HowMenyCharInt > 0; HowMenyCharInt++)
                {
                    //Ponowne ładowanie by zapobiedz nadpisanu zmienych ilość wystapienia
                    LoadAndOpereitOnFile();

                    //Tworzenie wszystkich możliwych kombinacji
                    List<List<Code>> AllCombination = new List<List<Code>>();
                    List<List<Code>> CombinationWithoutRepetitions = new List<List<Code>>();
                    List<List<Code>> AllCombinationCopi = new List<List<Code>>();
                    //Tworzenie listy składającej się z wszystkich kobinacji danej długości
                    AllCombination = shering.CreatWordWithSymbols(PriperSymbols, HowMenyCharInt);
                    //Kasowanie nadmiarowych kombinacji
                    AllCombinationCopi =new List<List<Code>>(AllCombination);
                    CombinationWithoutRepetitions = funkcjonSupport.DeliteReplikation(AllCombinationCopi);
                    
                    //Przepisywanie wystapień oraz sortowanie
                    List<int> HowMenySpeeches = new List<int>();
                    HowMenySpeeches = funkcjonSupport.HowMenyToList(CombinationWithoutRepetitions);
                    HowMenySpeeches.Sort();
                    //Przepisywanie odpowiedniej ilosci wynikow z najwieksą liczbą wystąpień
                    List<List<Code>> selectWords = new List<List<Code>>();
                    selectWords = funkcjonSupport.SelectWords(CombinationWithoutRepetitions, HowMenyResultInt, HowMenySpeeches, MinRedudationInt);
                    CombinationWithoutRepetitions = new List<List<Code>>();
                    //Wypisywanie wyników
                    Wraiting.Wraiting wraiting = new Wraiting.Wraiting();


                    //Dopisywanie słów do tablicy wyników
                    wraiting.WraitingSumary(Sumary, selectWords, HowMenyResultInt);

                    //Dodawanie do listy wszystke słowe spełniające warunek
                    
                    funkcjonSupport.TakeWords(AllCombination, selectWords, AllWordSelekted);
                    if (!(HowMenySpeeches[HowMenySpeeches.Count - 1] >= MinRedudationInt)||
                        (Sumary.Items.Count== HowMenyResultInt))
                    {
                        break;
                    }
                    selectWords = new List<List<Code>>();
                    HowMenySpeeches = new List<int>();
                    
                }
                MessageBox.Show("Ilośc znaleznionych wyników =" + Sumary.Items.Count.ToString());

            }
            else
            {
                MessageBox.Show("Plik jest nie prawidłowy lub jeden z paramaetrów został zle podany " +
                    "Minimalna długość musi być wieksza od 1," +
                    "Maksymalna ilosc wynikow musi byc wieksza od zera," +
                    "Minimalna liczba wystąpień musi byc wieksza od 1 ");
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            
            if (AllWordSelekted.Count>0&& savePath!=null)
            {
                string savePath1 = SavePath.Text;
                //Scierzka odczytanego pliku
                string path = Path.Text;
                File.FileSupport fileSupport = new FileSupport();
                //Tworzenie nowej scierzki
                string tmp = "";
                int lenghData = 0;
                for (int i = path.Length - 1; i > 0; i--)
                {
                    if (path[i] == '\\')
                    {
                        break;
                    }
                    lenghData++;

                }
                for (int i = path.Length - lenghData; i < path.Length-4; i++)
                {
                    tmp += path[i];
                }
                string newName ="\\"+tmp+ " W.csv";

                savePath1 += newName;

                fileSupport.DeliteAndCreateNewFile(savePath1);
                fileSupport.CreataFile(savePath1);
                fileSupport.AddLineToFile(savePath1, AllWordSelekted);

                MessageBox.Show("Plik został stworzony");
            }
        }

        
    }
}
