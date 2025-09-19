using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

//Declaracao do array de nomes dos alunos
string[] studentNames = new string[]
{
    "Sophia",
    "Andrew",
    "Emma",
    "Logan"
};


//Declaracao do arrays que receberam as notas.
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = [92, 89, 81, 96, 90];
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = [90, 95, 87, 88, 96];

int sophiaSum = 0;
decimal sophiaScore;

foreach (string name in studentNames)
{
    if (name == "Sophia")
    {
        foreach (int score in sophiaScores)
        {
            // add the exam score to the sum
            sophiaSum += score;
        }

        sophiaScore = (decimal)sophiaSum / currentAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
    }
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

