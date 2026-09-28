int iterationer = 10;
int[] array = {1, 2, 3, 4, 5};
// increment

try
{
    
    for (int i = 0 ; i<iterationer ; i++)
    {
        array[i]++;
    }
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Too much! Only this many:");
}
/*
for (int i=0 ; i<iterationer ; i++) {
array[i]++;
}*/


// print
for (int i=0 ; i<array.Length ; i++) {
Console.WriteLine(array[i]);
}

/*
try
{
    for (int i=0 ; i<array.Length ; i++)
    {
        Console.WriteLine(array[i]);
    };
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Too far!");
}
finally
{
    Console.WriteLine("Nothing");
}*/