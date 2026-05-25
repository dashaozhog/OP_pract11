//Завдання 1. Система сповіщень
//1. Створіть інтерфейс IMessenger з одним методом SendMessage(string message).
//2. Створіть три класи, що реалізують цей інтерфейс: EmailMessenger, SmsMessenger
//та PushMessenger.
//3. Кожен клас повинен реалізовувати метод SendMessage по-своєму, виводячи в
//консоль відповідне повідомлення (напр., "Відправка Email: [повідомлення]").
//4. У головній програмі створіть List<IMessenger>, додайте до нього об'єкти всіх трьох
//типів та надішліть однакове повідомлення через усі месенджери за допомогою циклу.
using System;
using System.Collections.Generic;

namespace Pract11;

public interface IMessenger
{
    void SendMessage(string message);
}

public class EmailMessanger : IMessenger
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Sending an email:\n" + message);
    }
}

public class SmsMessenger: IMessenger
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Sending SMS:\n" + message);
    }
}

public class PushMessenger : IMessenger
{
    public void SendMessage(string message)
    {
        Console.WriteLine("Pushing message:\n" + message);
    }
}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        EmailMessanger email = new EmailMessanger();
//        SmsMessenger sms = new SmsMessenger();
//        PushMessenger push = new PushMessenger();


//        List<IMessenger> msgs = new List<IMessenger> { email, sms, push };

//        foreach (IMessenger msg in msgs)
//        {
//            msg.SendMessage("HGUDHkjdjd 67676776767676767677652525525252");
//        }
//    }
//}


//Завдання 2. Ігрові персонажі
//1. Створіть інтерфейс IDamagable з методом TakeDamage(int damageAmount).
//2. Створіть два класи, що реалізують цей інтерфейс: Player(має поле Health) та
//Building(має поле Durability).
//3.Метод TakeDamage у кожному класі повинен зменшувати відповідне поле (здоров'я
//або міцність).
//4. У головній програмі створіть об'єкти гравця та будівлі. Продемонструйте, що
//обидва можуть отримати шкоду, викликавши для них метод TakeDamage.

public interface IDamagable
{
    void TakeDamage(int damageAmount);
}

public class Player: IDamagable
{
    public int Health { get; set; } = 100;

    public void TakeDamage(int damageAmount)
    {
        Health -= damageAmount;
        Console.WriteLine($"AUCH YOU BITCH [-{damageAmount}] \n HP left: {Health}");
    }
}

public class Building : IDamagable
{
    public int Durability { get; set; } = 1000;

    public void TakeDamage(int damageAmount)
    {
        Durability -= damageAmount;
        Console.WriteLine($"BABAMS [-{damageAmount}] \n HP left: {Durability}");
    }
}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        IDamagable player = new Player();
//        player.TakeDamage(67);

//        IDamagable building = new Building();
//        building.TakeDamage(520);
//    }
//}

//Завдання 3. Індивідуальне завдання
//ITransport (метод Move(),
//властивість Speed)

//Car, Bicycle, Boat Створити різні транспортні засоби.

//Продемонструвати їх рух.

interface ITransport
{
    int Speed {  get; set; }

    void Move();
}


