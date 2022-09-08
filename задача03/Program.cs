System.Console.WriteLine("Введите номер дня недели");
int day=Convert.ToInt32(Console.ReadLine());
if(day==1){
    System.Console.WriteLine("Рабочий-понедельник");
}
else if(day==2){
    System.Console.WriteLine("Рабочий-вторник");
}
else if(day==3){
    System.Console.WriteLine("Рабочая-среда");
}
else if(day==4){
    System.Console.WriteLine("Рабочий-четверг");
}
else if(day==5){
    System.Console.WriteLine("Рабочая-пятница");
}
else if(day==6){
    System.Console.WriteLine("Выходной-суббота");
}
else if(day==7){
    System.Console.WriteLine("Выходной-воскресенье");
}
else{
    System.Console.WriteLine("Несуществующий день недели");
}