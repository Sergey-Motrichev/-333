int n = 32679;

if(n<100){
    System.Console.WriteLine("третьей цифры нет");
}
else{
    int result= n/100%10;
    System.Console.WriteLine($"третья цифра числа{n}->{result}");
}

