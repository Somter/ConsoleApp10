using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class ClassMenu
    {
        Academy_Group academy_Group = new Academy_Group();
        bool running = true;

        public void Menu()
        {
            while (running)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить студента");
                Console.WriteLine("2. Удалить студента");
                Console.WriteLine("3. Редактировать студента");
                Console.WriteLine("4. Показать группу");
                Console.WriteLine("5. Сохранить данные");
                Console.WriteLine("6. Загрузить данные");
                Console.WriteLine("7. Поиск студента");
                Console.WriteLine("8. Сортировать студентов");
                Console.WriteLine("9. Использовать сериализацию");
                Console.WriteLine("10.Использовать десериализацию");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Введите имя: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите фамилию: ");
                        string surname = Console.ReadLine();
                        Console.Write("Введите телефон: ");
                        string phone = Console.ReadLine();
                        Console.Write("Введите возраст: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Введите средний балл: ");
                        double average = double.Parse(Console.ReadLine());
                        Console.Write("Введите номер группы: ");
                        int numberOfGroup = int.Parse(Console.ReadLine());

                        Student student = new Student(name, surname, age, phone, average, numberOfGroup);
                        academy_Group.Add(student);
                        break;

                    case "2":
                        Console.Write("Введите фамилию студента для удаления: ");
                        string remove_surname = Console.ReadLine();
                        academy_Group.Remove(remove_surname);
                        break;

                    case "3":
                        Console.Write("Введите фамилию студента для редактирования: ");
                        string editSurname = Console.ReadLine();

                        Console.Write("Введите новое имя: ");
                        string newName = Console.ReadLine();
                        Console.Write("Введите новую фамилию: ");
                        string newSurname = Console.ReadLine();
                        Console.Write("Введите новый телефон: ");
                        string newPhone = Console.ReadLine();
                        Console.Write("Введите новый возраст: ");
                        int newAge = int.Parse(Console.ReadLine());
                        Console.Write("Введите новый средний балл: ");
                        double newAverage = double.Parse(Console.ReadLine());
                        Console.Write("Введите новый номер группы: ");
                        int newNumberOfGroup = int.Parse(Console.ReadLine());

                        Student newStudent = new Student(newName, newSurname, newAge, newPhone, newAverage, newNumberOfGroup);
                        academy_Group.Edit(editSurname, newStudent);
                        break;

                    case "4":
                        academy_Group.Print();
                        break;

                    case "5":
                        academy_Group.Save();
                        break;

                    case "6":
                        academy_Group.Load();
                        break;

                    case "7":
                        Console.WriteLine("Выберите критерий для поиска:");
                        Console.WriteLine("1. Имя");
                        Console.WriteLine("2. Фамилия");
                        Console.WriteLine("3. Телефон");
                        Console.WriteLine("4. Возраст");
                        Console.WriteLine("5. Средний балл");
                        Console.WriteLine("6. Номер группы");
                        Console.Write("Ваш выбор: ");

                        int search_criterion = int.Parse(Console.ReadLine());
                        academy_Group.Search(search_criterion);
                        break;

                    case "8": 
                        Console.WriteLine("Выберите критерий для сортировки:");
                        Console.WriteLine("1. Имя");
                        Console.WriteLine("2. Фамилия");
                        Console.WriteLine("3. Возраст");
                        Console.Write("Ваш выбор: ");

                        int sorting_criterion = int.Parse(Console.ReadLine());
                        academy_Group.Sort(sorting_criterion);
                        break;
                    case "9":
                        Console.WriteLine("\nВыберите формат для сериализации:");
                        Console.WriteLine("1. XML");
                        Console.WriteLine("2. JSON");
                        Console.WriteLine("3. SOAP");
                        Console.Write("Ваш выбор: ");
                        string serializationChoice = Console.ReadLine();
                        switch (serializationChoice)
                        {
                            case "1":
                                academy_Group.SerializeToXML("data.xml");
                                break;
                            case "2":
                                academy_Group.SerializeToJSON("data.json");
                                break;
                            case "3":
                                academy_Group.SerializeToSOAP("data.soap");
                                break;
                            default:
                                Console.WriteLine("Неверный выбор!");
                                break;
                        }
                        break;
                    case "10":
                        Console.WriteLine("\nВыберите формат для десериализации:");
                        Console.WriteLine("1. XML");
                        Console.WriteLine("2. JSON");
                        Console.WriteLine("3. SOAP");
                        Console.Write("Ваш выбор: ");
                        string deserializationChoice = Console.ReadLine();
                        switch (deserializationChoice)
                        {
                            case "1":
                                academy_Group.DeserializeFromXML("data.xml");
                                break;
                            case "2":
                                academy_Group.DeserializeFromJSON("data.json");
                                break;
                            case "3":
                                academy_Group.DeserializeFromSOAP("data.soap");
                                break;
                            default:
                                Console.WriteLine("Неверный выбор!");
                                break;
                        }
                        break;
                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }  
        }
    }
}
