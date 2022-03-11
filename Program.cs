int nomre;
double sum=0;
int avg=0;
int Counter=-1;
do
{
    System.Console.WriteLine("nomre bede");
    nomre=Convert.ToInt32(Console.ReadLine());
    sum=sum+nomre;
    Counter++;
    avg=avg=nomre;
} while (nomre<=20 && nomre !=0);
System.Console.WriteLine(sum/Counter);
