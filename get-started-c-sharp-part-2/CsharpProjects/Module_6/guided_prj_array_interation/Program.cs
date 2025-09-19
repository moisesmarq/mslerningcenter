using System;

// initialize variables - graded assignments 
int tarefas_notas_normais = 5;

//Declaracao do array de nomes dos alunos
string[] studentNames = new string[]
{
    "Sophia",
    "Andrew",
    "Emma",
    "Logan"
};

//Declaracao do arrays que receberam as notas.
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 }; //Adicinado notas extras: 94 e 90
int[] andrewScores = [92, 89, 81, 96, 90, 89];  //Adicinado notas extras: 89
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 }; //Adicinado notas extras: 89, 89, 89
int[] loganScores = [90, 95, 87, 88, 96, 96]; //Adicinado notas extras: 96

//Array que vai receber os array de notas do estudantes
int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }

    int scoreSum = 0;
    decimal currentStudentGrade = 0;
    int tarefas_notas_extras = 0;

    foreach (int score in studentScores)
    {   
        tarefas_notas_extras++;
        if (tarefas_notas_extras > tarefas_notas_normais)
        {
            scoreSum += score / 10;
        }
        else
        {
            // add the exam score to the sum
            scoreSum += score;
        }
    }

    currentStudentGrade = (decimal)scoreSum / tarefas_notas_normais;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

