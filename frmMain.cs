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

namespace MelindaFischerAssessment2
{
    public partial class frmMain : Form
    {
        List<Animal> animalsList = new List<Animal>();
        IComparer arrayCompare = new arrayComparer();

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

        public class arrayComparer : IComparer
        {
            public int Compare(Object x, Object z)
            {
                return (new CaseInsensitiveComparer()).Compare(x, z);
            }
        }


        private StreamReader fileReader; //Reads data from textfile
        //Form-wide variables
        
        string[] animals = new string[15];
        int tracker = 0;
        int numberTracker = 0;
        int[] numberOfAnimals = new int[15];

        public frmMain()
        {
            InitializeComponent();
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            frmPaint myPaint = new frmPaint();
            myPaint.ShowDialog();
        }

        private void btnAdventureGame_Click(object sender, EventArgs e)
        {
            frmAvatar myAvatar = new frmAvatar();
            myAvatar.ShowDialog();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string animalFile = "C:/Users/MelindaFischer/source/repos/MelindaFischerAssessment2/bin/Debug/animals.txt";
            string numberFile = "C:/Users/MelindaFischer/source/repos/MelindaFischerAssessment2/bin/Debug/numberOfAnimals.txt";


            FileStream input = new FileStream(animalFile, FileMode.Open, FileAccess.Read);

            fileReader = new StreamReader(input);


            //Get next record from file
            while (!fileReader.EndOfStream)
            {
                string inputAnimals = fileReader.ReadLine();


                animals[tracker] = ((inputAnimals));
              //  listBoxAnimals.Items.Add(animals[tracker]);
                tracker++;
            }

            //Close StreamReader and associated file
            fileReader.Close();

            FileStream input2 = new FileStream(numberFile, FileMode.Open, FileAccess.Read);

            fileReader = new StreamReader(input2);


            //Get next record from file
            while (!fileReader.EndOfStream)
            {
                string inputNumbers = fileReader.ReadLine();


                numberOfAnimals[numberTracker] = (Convert.ToInt32(inputNumbers));
                //listBoxNumbers.Items.Add(numberOfAnimals[numberTracker]);
                numberTracker++;
            }

            //Close StreamReader and associated file
            fileReader.Close();

            //save t
            for (int i = 0; i<15; i++)
            { 
                animalsList.Add(new Animal() { name = animals[i], amount = numberOfAnimals[i] });
            }

            animalsList.Sort();
            
            foreach (var element in animalsList)
            {
                listBoxAnimals.Items.Add(element);
            }
        }

        private void btnOpenNumber_Click(object sender, EventArgs e)
        {
            string animalFile = "C:/Users/MelindaFischer/source/repos/MelindaFischerAssessment2/bin/Debug/animals.txt";
           
            FileStream input = new FileStream(animalFile, FileMode.Open, FileAccess.Read);

            fileReader = new StreamReader(input);


            //Get next record from file
            while (!fileReader.EndOfStream)
            {
                string inputAnimals = fileReader.ReadLine();
                
                animals[tracker] = ((inputAnimals));
                tracker++;
            }

            //Close StreamReader and associated file
            fileReader.Close();

            Array.Sort(animals, arrayCompare);
            foreach (var element in animals)
            {
                listBoxAnimals.Items.Add(element);
            }


        }
    }
    }

