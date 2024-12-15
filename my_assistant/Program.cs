Console.WriteLine("Привет я искусственный интелект я готов помочь");
Console.WriteLine("Как тебя зовут?");
string? name = Console.ReadLine();
Console.WriteLine($"Приятно познокомится {name}");
Console.Write("Сколько тебе лет? {Введите число}: ");
int age = int.Parse(Console.ReadLine());
if (age<25)
{
    Console.WriteLine("О ты еще юн! У теб еще много интереснного.");
}
else
{
    Console.WriteLine("О так ты старый тебе пора на пенсию");
}
Console.WriteLine("Чем я могу тебе помочь? {Выбирите один из вариантов:}");
Console.WriteLine("1-Узнать погоду");
Console.WriteLine("2-Рассказать анекдот");
Console.WriteLine("3-Дать совет");
Console.WriteLine("4-Попращятся");
Console.Write("Выбирите вариант ответа 1-4: ");
int choice = int.Parse(Console.ReadLine());
switch (choice){
    case 1:
        Console.WriteLine("Сейчас холодно, рекомедовано сидеть дома пить виски");
        break;
    case 2:
        Console.WriteLine("Обычно у людей оптимизм - это врождённое свойство. А пессимизм - благоприобретённое.");
        break;
    case 3:
        Console.WriteLine("Дайте человеку полностью договорить, а потом задайте уточняющие вопросы?");
        break;
    case 4:
        Console.WriteLine("Поки");
        break; 
    default:
        Console.WriteLine("Я не понял, что вы хотели");
        break;
}
Console.WriteLine("Спасибо большое за использования моей программы. Удачного дня вам!")
