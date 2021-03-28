using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Media;


namespace HomeWork_1
{
    public partial class Calculater : Form
    {
        public Calculater()
        {
            InitializeComponent();

        }
        private void Calculater_Load(object sender, EventArgs e)
        {

            SoundPlayer mozart = new SoundPlayer();
            string mozartdirectory = Application.StartupPath + "\\Mozart.wav ";

            mozart.SoundLocation = mozartdirectory;
            mozart.Play();

            notificationOne.BalloonTipIcon = ToolTipIcon.Info;
            notificationOne.BalloonTipText = "Object Oriented Programming Assignment 1 \n Calculator";
            notificationOne.BalloonTipTitle = "Welcome to the Program";
            notificationOne.ShowBalloonTip(3000);

        }

        public void SetScreen()
        {

            mskTxtBoxStart.Text = mskTxtBoxFinish.Text = "";

            mskTxtBoxStart.Focus();

        }

        public void NullWarning()
        {

            SoundPlayer valuesound = new SoundPlayer();
            string valuedirectory = Application.StartupPath + "\\PleaseEnterValue.wav";

            valuesound.SoundLocation = valuedirectory;
            valuesound.Play();

            string value = "Please, Enter Value";
            MessageBox.Show(value);

        }

        public bool BlankEntryControl()
        {

            try
            {

                Convert.ToInt32(mskTxtBoxStart.Text);
                Convert.ToInt32(mskTxtBoxFinish.Text);

                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

        public void OddTotalReturntoResult(int startNumber, int finishNumber)
        {
            BigInteger oddTotal = 0;

            for (int i = startNumber; i <= finishNumber; i++)
            {
                if ((i % 2) == 0)
                {

                    lvNumbersOdd.Items.Add("Odd Number:   " + i.ToString());
                    oddTotal += i;

                }
            }

            lvTotalOdd.Items.Add("Odd Total:" + oddTotal.ToString());

        }

        public void OddMultiplicationReturntoResult(int startNumber, int finishNumber)
        {
            BigInteger oddMultiplication = 1;

            for (int i = startNumber; i <= finishNumber; i++)
            {
                if ((i % 2) == 0)
                {

                    oddMultiplication *= i;

                }
            }

            lvMultiplicationOdd.Items.Add("Odd Multiplication:" + oddMultiplication.ToString());

        }

        public void EvenTotalReturntoResult(int startNumber, int finishNumber)
        {
            BigInteger evenTotal = 0;

            for (int i = startNumber; i <= finishNumber; i++)
            {
                if ((i % 2) == 1)
                {

                    lvNumbersEven.Items.Add("Even Number:" + i.ToString());
                    evenTotal += i;

                }
            }

            lvTotalEven.Items.Add("Even Total:" + evenTotal.ToString());

        }

        public void EvenMultiplicationReturntoResult(int startNumber, int finishNumber)
        {
            BigInteger evenMultiplication = 1;

            for (int i = startNumber; i <= finishNumber; i++)
            {
                if ((i % 2) == 1)
                {

                    evenMultiplication *= i;

                }
            }

            lvMultiplicationEven.Items.Add("Even Multiplication:" + evenMultiplication.ToString());

        }

        public void PrimeTotalReturntoResult(int startNumber, int finishNumber)
        {

            BigInteger primeTotal = 0;

            for (int i = startNumber; i <= finishNumber; i++)
            {
                int check = 0;

                if (i == 0 || i == 1)
                    continue;

                for (int m = 2; m < i; m++)
                {
                    if (i % m == 0)
                    {
                        check = 1;
                        break;

                    }
                }
                if (check == 1)
                {
                }
                else
                {

                    lvNumberPrime.Items.Add("Prime Number:" + i.ToString());
                    primeTotal += i;

                }
            }
            lvTotalPrime.Items.Add("Prime Total:" + primeTotal.ToString());
        }

        public void PrimeMultiplicationReturntoResult(int startNumber, int finishNumber)
        {

            BigInteger Multiplication = 1;

            for (int i = startNumber; i <= finishNumber; i++)
            {
                int check = 0;

                if (i == 0 || i == 1)
                    continue;

                for (int m = 2; m < i; m++)
                {
                    if (i % m == 0)
                    {
                        check = 1;
                        break;

                    }
                }
                if (check == 1)
                {

                }
                else
                {

                    Multiplication *= i;

                }
            }
            lvMultiplicationPrime.Items.Add("Prime Multiplication:" + Multiplication.ToString());
        }

        public void ArmstrongTotalReturntoResult(int startNumber, int finishNumber)
        {

            BigInteger armstrongTotal = 0;

            int i, digitsOfTheNumber, sum, temp;

            for (i = startNumber; i <= finishNumber; i++)
            {
                temp = i;
                sum = 0;

                if (i < 10)
                {

                    while (temp != 0)
                    {
                        digitsOfTheNumber = temp % 10;
                        temp = temp / 10;
                        sum = sum + (digitsOfTheNumber);
                    }

                    if (sum == i)
                    {

                        lvNumbersArmstrong.Items.Add("Armstrong Number:" + i.ToString());
                        armstrongTotal += sum;

                    }
                }

                else if (i < 1000)
                {

                    while (temp != 0)
                    {
                        digitsOfTheNumber = temp % 10;
                        temp = temp / 10;
                        sum = sum + (digitsOfTheNumber * digitsOfTheNumber * digitsOfTheNumber);
                    }

                    if (sum == i)
                    {

                        lvNumbersArmstrong.Items.Add("Armstrong Number:" + i.ToString());
                        armstrongTotal += sum;

                    }
                }

                else 
                {
                    while (temp != 0)
                    {
                        digitsOfTheNumber = temp % 10;
                        temp = temp / 10;
                        sum = sum + (digitsOfTheNumber * digitsOfTheNumber * digitsOfTheNumber * digitsOfTheNumber);
                    }

                    if (sum == i)
                    {

                        lvNumbersArmstrong.Items.Add("Armstrong Number:" + i.ToString());
                        armstrongTotal += sum;

                    }
                }             
            }
            lvTotalArmstrong.Items.Add("Armstrong Total:" + armstrongTotal.ToString());
        }

        public void ArmstrongMultiplicationReturntoResult(int startNumber, int finishNumber)
        {

            BigInteger armstrongMultliplication = 1;

            int i, digitsOfTheNumber, sum, temp;

            for (i = startNumber; i <= finishNumber; i++)
            {
                temp = i;
                sum = 0;

                if (i < 10)
                {

                    while (temp != 0)
                    {
                        digitsOfTheNumber = temp % 10;
                        temp = temp / 10;
                        sum = sum + (digitsOfTheNumber);
                    }

                    if (sum == i)
                    {
                    
                        armstrongMultliplication *= sum;

                    }
                }

                else if (i < 1000)
                {

                    while (temp != 0)
                    {
                        digitsOfTheNumber = temp % 10;
                        temp = temp / 10;
                        sum = sum + (digitsOfTheNumber * digitsOfTheNumber * digitsOfTheNumber);
                    }

                    if (sum == i)
                    {

                        armstrongMultliplication *= sum;

                    }
                }

                else
                {
                    while (temp != 0)
                    {
                        digitsOfTheNumber = temp % 10;
                        temp = temp / 10;
                        sum = sum + (digitsOfTheNumber * digitsOfTheNumber * digitsOfTheNumber * digitsOfTheNumber);
                    }

                    if (sum == i)
                    {

                        armstrongMultliplication *= sum;

                    }
                }
            }
            lvMultiplitionArmstrong.Items.Add("Armstrong Multliplication:" + armstrongMultliplication.ToString());
        }

        private void Calculater_Shown(object sender, EventArgs e)
        {

            string startingTab = System.Configuration.ConfigurationManager.AppSettings["startingTab"];
            this.allTabs.SelectTab(startingTab);

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int startNumber, finishNumber;


            if (BlankEntryControl())
            {

                startNumber = Convert.ToInt32(mskTxtBoxStart.Text);
                finishNumber = Convert.ToInt32(mskTxtBoxFinish.Text);


                if (finishNumber > startNumber)
                {
                    SoundPlayer calculate = new SoundPlayer();
                    string calculatedirectory = Application.StartupPath + "\\CalculatingForYou.wav ";

                    calculate.SoundLocation = calculatedirectory;
                    calculate.Play();

                    if (allTabs.SelectedTab == tbPgOddNbs)
                    {

                        lvNumbersOdd.Items.Clear();
                        lvTotalOdd.Items.Clear();
                        lvMultiplicationOdd.Items.Clear();

                        OddTotalReturntoResult(startNumber, finishNumber);
                        OddMultiplicationReturntoResult(startNumber, finishNumber);

                        SetScreen();

                    }

                    else if (allTabs.SelectedTab == tbPgEvenNbs)
                    {

                        lvNumbersEven.Items.Clear();
                        lvTotalEven.Items.Clear();
                        lvMultiplicationEven.Items.Clear();

                        EvenTotalReturntoResult(startNumber, finishNumber);
                        EvenMultiplicationReturntoResult(startNumber, finishNumber);

                        SetScreen();

                    }

                    else if (allTabs.SelectedTab == tbPgPrimeNbs)
                    {


                        lvNumberPrime.Items.Clear();
                        lvTotalPrime.Items.Clear();
                        lvMultiplicationPrime.Items.Clear();

                        PrimeTotalReturntoResult(startNumber, finishNumber);
                        PrimeMultiplicationReturntoResult(startNumber, finishNumber);

                        SetScreen();

                    }

                    else if (allTabs.SelectedTab == tbPgArmstrongNbs)
                    {


                        lvNumbersArmstrong.Items.Clear();
                        lvTotalArmstrong.Items.Clear();
                        lvMultiplitionArmstrong.Items.Clear();

                        ArmstrongTotalReturntoResult(startNumber, finishNumber);
                        ArmstrongMultiplicationReturntoResult(startNumber, finishNumber);

                        SetScreen();

                    }

                }
                else
                {

                    SoundPlayer finishtIsGreaterThanStartsound = new SoundPlayer();
                    string finishtIsGreaterThanStartdirectory = Application.StartupPath + "\\StartNumberFinishNumber.wav ";

                    finishtIsGreaterThanStartsound.SoundLocation = finishtIsGreaterThanStartdirectory;
                    finishtIsGreaterThanStartsound.Play();

                    string finishtIsGreaterThanStart = "Start number cannot be less than finish number.";
                    MessageBox.Show(finishtIsGreaterThanStart);

                    SetScreen();
                }
            }
            else
            {

                NullWarning();

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            SoundPlayer back = new SoundPlayer();
            string backdirectory = Application.StartupPath + "\\Back.wav ";

            back.SoundLocation = backdirectory;
            back.Play();

            if (allTabs.SelectedTab == tbPgOddNbs)
            {

                allTabs.SelectedTab = tbPgArmstrongNbs;

            }

            else
            {
                allTabs.SelectedIndex -= 1;
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            SoundPlayer forward = new SoundPlayer();
            string forwarddirectory = Application.StartupPath + "\\Forward.wav ";

            forward.SoundLocation = forwarddirectory;
            forward.Play();

            if (allTabs.SelectedTab == tbPgArmstrongNbs)
            {

                allTabs.SelectedTab = tbPgOddNbs;

            }

            else
            {
                allTabs.SelectedIndex += 1;
            }

        }

        private void wiewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





