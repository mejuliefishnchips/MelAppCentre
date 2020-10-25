//****************************************************************
// Programmer: Melinda Fischer
// CIT Number: CIT245143
// Date: 25 September 2020
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64-bit 
// Purpose: Assignment2 - Main Menu to get into Paint and Avatar Selection
// Criteria Shown: Comparators
// References: Class notes, stackoverflow, Microsoft Docs, dotnetperls
//**************************************************************** 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace MelindaFischerAssessment2
{
    public partial class frmMain : Form
    {
        //Form-wide variables

        string animalFile;
        string[] animals = new string[15];
        int tracker = 0;
        int numberTracker = 0;
        int[] numberOfAnimals = new int[15];
        private StreamReader fileReader; //Reads data from textfile
        List<Animal> animalsList = new List<Animal>();
        IComparer arrayCompare = new arrayComparer();


        //setting up the class Animal that will use IComparable to sort through instances of the type Animal
        class Animal : IComparable<Animal>
        {
            public string name { get; set; }
            public int amount { get; set; }

            public int CompareTo(Animal other)
            {
                if (this.amount == other.amount)
                {
                    return this.name.CompareTo(other.name);
                }
                return other.amount.CompareTo(this.amount);
            }

            public override string ToString()
            {
                return this.amount.ToString() + " - " + this.name;
            }
        }

        // setting up the class arrayComparer that will use IComparer to sort through a 1d array
        public class arrayComparer : IComparer
        {
            public int Compare(Object x, Object z)
            {
                return (new CaseInsensitiveComparer()).Compare(x, z);
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Opening Paint form
        private void btnPaint_Click(object sender, EventArgs e)
        {
            frmPaint myPaint = new frmPaint();
            myPaint.ShowDialog();
        }

        //Loading animal text file into the array and displaying it in the listbox
        private void btnLoadAnimals_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select the text file called animals.txt located in bin/debug","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnLoadAnimals.Enabled = false;


            // Set filter for open file dialog
            dlgOpen.Filter = "Text files (*.txt) | *.txt";
            dlgOpen.FileName = "Select File";

            // Capture file name from open file dialog
            if (dlgOpen.ShowDialog() != DialogResult.Cancel)
            {
                btnOpenAmount.Enabled = true;
                animalFile = dlgOpen.FileName;


                FileStream input = new FileStream(animalFile, FileMode.Open, FileAccess.Read);

                fileReader = new StreamReader(input);

                tracker = 0;

                //Get next record from file
                while (!fileReader.EndOfStream)
                {
                    string inputAnimals = fileReader.ReadLine();

                    animals[tracker] = ((inputAnimals));
                    tracker++;
                }

                //Close StreamReader and associated file
                fileReader.Close();

                listBoxArray.BackColor = System.Drawing.Color.Orchid;

                foreach (var element in animals)
                {
                    listBoxArray.Items.Add(element);
                }
            }
            else
            {
                MessageBox.Show("Please select a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLoadAnimals.Enabled = true;
            }

        }

        // Loading animal and number text file into instances of the class Animal and displaying it in the list box 
        private void btnOpenAmount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select the text file called numberOfAnimals.txt located in bin/debug", "Information",MessageBoxButtons.OK, MessageBoxIcon.Information );
            btnOpenAmount.Enabled = false;
            
                string animalFile = dlgOpen.FileName;

                //Opening animal file to load into array
                FileStream input = new FileStream(animalFile, FileMode.Open, FileAccess.Read);

                fileReader = new StreamReader(input);
                tracker = 0;

                //Get next record from file
                while (!fileReader.EndOfStream)
                {
                    string inputAnimals = fileReader.ReadLine();
                    //Loading line by line animals into array
                    animals[tracker] = ((inputAnimals));
                    tracker++;
                }

                //Close StreamReader and associated file
                fileReader.Close();
            
        
            // Set filter for open file dialog
            dlgOpen.Filter = "Text files (*.txt) | *.txt";
            dlgOpen.FileName = "Select File";

            // Capture file name from open file dialog
            if (dlgOpen.ShowDialog() != DialogResult.Cancel)
            {
                string numberFile = dlgOpen.FileName;
                //opening number file to load into array
                FileStream input2 = new FileStream(numberFile, FileMode.Open, FileAccess.Read);

                fileReader = new StreamReader(input2);

                //Get next record from file
                while (!fileReader.EndOfStream)
                {
                    string inputNumbers = fileReader.ReadLine();

                    numberOfAnimals[numberTracker] = (Convert.ToInt32(inputNumbers));
                    numberTracker++;
                }

                //Close StreamReader and associated file
                fileReader.Close();
                listBoxAmount.BackColor = System.Drawing.Color.Orchid;

                //save name and amount into instances of the Animal List
                for (int i = 0; i < 15; i++)
                {
                    animalsList.Add(new Animal() { name = animals[i], amount = numberOfAnimals[i] });
                }

                //display animalList in the listbox
                foreach (var element in animalsList)
                {
                    listBoxAmount.Items.Add(element);
                }
            }
            else
            {
                MessageBox.Show("Please select a file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOpenAmount.Enabled = true;
            }
               
            }

        
        //Opening Avatar Form
        private void btnAvatar_Click(object sender, EventArgs e)
        {
            frmAvatar myAvatar = new frmAvatar();
            myAvatar.ShowDialog();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
        
            // clear listbox and display back color of listbox in green -> sorted 
            listBoxAmount.Items.Clear();
            listBoxAmount.BackColor = System.Drawing.Color.LightGreen;

            listBoxArray.Items.Clear();
            listBoxArray.BackColor = System.Drawing.Color.LightGreen;

            // Sort the entire array by using custom comparer.
            Array.Sort(animals, arrayCompare);
            //display animal array in listbox after being sorted
            foreach (var element in animals)
            {
                listBoxArray.Items.Add(element);
            }

            // Uses IComparable.CompareTo()
            animalsList.Sort();
            //display animalList in the listbox after being sorted
            foreach (var element in animalsList)
            {
                listBoxAmount.Items.Add(element);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnOpenAmount.Enabled = false;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application was developed by Melinda Fischer to meet the criteria for  her C# Assessment2", "About this Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            string filename = "https://tda.edu.au/wp-content/uploads/2020/10/Melindas-Little-App-Centre-Application-Documentation.pdf";
            System.Diagnostics.Process.Start(filename);
        }
    }
    }

