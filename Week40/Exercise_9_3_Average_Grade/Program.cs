//Not jet Finished. Didn't know how to use the function and calcclate the average



int[] grades = {-03 , 00 , 02 , 4 , 7 , 10 , 12};

int GetGrade ()
{
    
    for (int courseid = 0; courseid<grades.Length; courseid++)
    {
        int grade = grades[courseid];
        if (grade>02)
        {
            Console.WriteLine(grade);
        }
        else
        {
            throw new Exception("FAIL!");
            Console.WriteLine(e.message);
        }
    }

}

int count;
int sum;

for (int i = 0; i<grades.Length; i++)
{
    count++;
    sum = GetGrade();
    int average = sum/count;
    Console.WriteLine(average);
}