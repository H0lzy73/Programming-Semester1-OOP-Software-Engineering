//Not jet Finished. Didn't know how to use the function and calcclate the average



int[] grades = {-03 , 00 , 02 , 4 , 7 , 10 , 12, 10, 10, 4, 7, 4, 7};

int GetGrade (int i)
{
    
    
        int grade = grades[i];
        //Console.WriteLine("test");
        if (grade>=2)
        {
            //Console.WriteLine(grade);
            return grade;
            
        }
        else
        {
            //Console.WriteLine(Exception);
            return 0;
            //Console.WriteLine("test");
        }

}

double count = 0;
double sum = 0;

for (int i = 0; i<grades.Length; i++)
{
    int onegrade = GetGrade(i);
    sum = sum + onegrade;
    Console.WriteLine("Sum: " + sum);
    count++;
    //sum = int GetGrade();
    Console.WriteLine("Count: " +count);
    double average = sum/count;
    Console.WriteLine("Average: " +average);
}