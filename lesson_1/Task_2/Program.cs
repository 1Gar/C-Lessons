
/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/



int a = 2;
int b = 3;
int c = 7;
int max = a;

if (a>b){
    if (a>c){
        max = a;
    }else{
        max = c;
    }
}else{
    max = b;
    if (b>c){
        max = b;
    }else{
        max = c;
    }
}

Console.WriteLine(max);
