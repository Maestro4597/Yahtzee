
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

List<int> dice = new List<int>() { 0, 0, 0, 0, 0 };

int ones;
int onesSum;

int twos;
int twosSum;

int threes;
int threesSum;

int fours;
int foursSum;

int fives;
int fivesSum;

int six;
int sixSum;


int Ones()
{
    for (int i=0; i<dice.Count();i++)
    {

        if (dice[i] == 1)
            onesSum++;
         ones =  onesSum * 1;
    }
    return ones;
}

int Twos()
{
    for (int i = 0; i < dice.Count(); i++)
    {

        if (dice[i] == 2)
            twosSum++;
        twos = twosSum * 2;
    }
    return twos;
}


int Threes()
{
    for (int i = 0; i < dice.Count(); i++)
    {

        if (dice[i] == 3)
            threesSum++;
        threes = threesSum * 3;
    }
    return threes;
}


int Fours()
{
    for (int i = 0; i < dice.Count(); i++)
    {

        if (dice[i] == 4)
            foursSum++;
        fours = foursSum * 4;
    }
    return fours;
}


int Fives()
{
    for (int i = 0; i < dice.Count(); i++)
    {

        if (dice[i] == 5)
            fivesSum++;
        fives = fivesSum * 5;
    }
    return fives;
}


int Six()
{
    for (int i = 0; i < dice.Count(); i++)
    {

        if (dice[i] == 6)
            sixSum++;
        six = sixSum * 6;
    }
    return six;
}


int isYahtzee()
{
    int firstDie = dice[0];

    for (int i = 0; i < dice.Count; i++)

    {
        if(dice[i] != firstDie)
            return 0;
    }

    return 50;
}


int chance()
{
    int diceSum = 0;

    for (int i=0;i<dice.Count;i++)
    {
        diceSum = dice[i] + dice[i++];
    }

    return diceSum;

}

int threeOfAKind()
{
    int counter = 0;
    for (int i = 0; i < dice.Count; i++)
    {
        for (int j = i++; j < dice.Count - j; j++)
        {
            if (dice[i] == dice[j])
            {
                counter++;
                if (counter < 3 || counter > 3)
                {
                    return 0;
                }
            }
        }
    }


    return chance();
}

int fourOfAKind()
{
    int counter = 0;
    

    for (int i = 0; i < dice.Count; i++)
    {
        for (int j = i++; j < dice.Count - j; j++)
        {

            if (dice[i] == dice[j])
            {
                counter++;
               
                if (counter < 4 || counter > 4)
                {
                    return 0;
                }
            }
        }
    }


    return chance();
}


int fullHouse()
{
    int counter = 0;
    int nextCounter = 0;

    for (int i = 0; i < dice.Count; i++)
    {
        for (int j = i++; j < dice.Count - j; j++)
        {

            if (dice[i] == dice[j])
            {
                counter++;

                if (counter==3)
                {
                    for(int k=0; k<dice.Count; k++)
                    {
                        for(int l=k++; l<dice.Count-l; l++)
                        {
                            if (dice[k] == dice[l])

                                nextCounter++;

                            if (nextCounter == 2)
                                return 25;

                        }
                        
                    }
                    
                }
            }
        }
    }

    return 0;
}




int smallStraight()
{
    Array.Sort(dice);

    for(int i=0; i<dice.Count;i++)
    {
        for (int j = i++; j < dice.Count; j++)
            if ((j - i) ==1)
                i++;
                return 0;
    }

    return 30;
}


int largeStraight()
{






    return 40;
}




namespace Week3_CSharp_Yahtzee_
{
    public partial class Form1 : Form
    {




        public Form1()
        {

            InitializeComponent();
        }








      





    }






}



