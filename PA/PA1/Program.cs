int[] numbers;      //declaring the integer array "numbers"
//for testing different scenarios:
numbers = [0, 10, 55, -1, -100000000];
// numbers = [3, 5, 100];
// numbers = [-10, 5, -2, 3, -20]

int biggest_negativ_number; //I interpret "biggest negative number" as the number of which the absolute value is the biggest e.g -100 is "bigger" than -5
biggest_negativ_number = 0; //declaring a variable to store the biggest negativ number; right now set to 0 

foreach(int i in numbers) { //loop to got trough the array 
    //Console.WriteLine(i);
    if (i<0) { //this looks at each element in the array and if it is less than 0 the if statement is true
        //Console.WriteLine(i); //Writes generally every negativ number (just to know if the programm sees every negativ number 
        if (biggest_negativ_number > i) { // checks if the element which is look at (i) is smaller than the biggest negativ number. If it is than the if statement is true
        biggest_negativ_number = i; //updates the variable to be the new biggest negative number
        };
    };
};

if (biggest_negativ_number == 0) { //this checks if the variable "biggest_negative_number" is still 0, if yes than the program knows there was no negativ number in the array and returns that
    Console.WriteLine("There is no negatvi Number meaning there can't be a biggest one :´(");
}

else { // if the variable biggest_negativ_number is not 0 the program returns the biggest negativ number
    Console.WriteLine("Biggest negative number of the Array: " + biggest_negativ_number);
};