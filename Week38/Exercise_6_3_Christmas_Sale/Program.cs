int time_since_new_year = 21816000;
double price = 599.95;
double real_price = 599.95;

while (true) {
    if (time_since_new_year == 31104000) {
        real_price = price * 0.7;
        break;
    }
    real_price = price;
    time_since_new_year++;
    Console.WriteLine(real_price);
}

