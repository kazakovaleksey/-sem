//принмает число и выдает количество цифр в нем

Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (int i = 0; A>0; i++)

{
    A/=10;
    count++;
}

Console.WriteLine(count);