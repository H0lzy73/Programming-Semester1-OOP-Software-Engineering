double celcius= -5;
double Fahrenheit=0;

while (celcius <40.5) {

    //Console.WriteLine("{0,10}{1,10}", celcius[DisplayPos], Fahrenheit[DisplayPos]);
    //Console.WriteLine($"{celcius} | {Fahrenheit}",4);
    
    celcius = celcius+0.5;
    Fahrenheit = 32 + celcius * (9/5); 
}
    