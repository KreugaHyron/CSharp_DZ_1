namespace C__DZ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1 - Пользователь вводит с клавиатуры показания температуры. Перевести температуру из Цельсия в Фаренгейты.

            Console.Write("Введите температуру в градусах Цельсия: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit:F2}");
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите допустимое числовое значение.");
            }
            //Tаsk_2 - Напишите программу, которая вычисляет объём шара.

            Console.Write("Введите радиус шара: ");

            string input_1 = Console.ReadLine();
            double radius;
            double.TryParse(input_1, out radius);

            radius = Math.Max(radius, 0);

            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

            Console.WriteLine($"Объём шара: {volume:F2}");

            //Task_3 - Пользователь вводит с клавиатуры стоимость одного ноутбука, их количество и процент скидки. Посчитать общую сумму заказа.

            Console.Write("Введите стоимость одного ноутбука: ");
            string inputPrice = Console.ReadLine();
            double.TryParse(inputPrice, out double price);

            Console.Write("Введите количество ноутбуков: ");
            string inputQuantity = Console.ReadLine();
            int.TryParse(inputQuantity, out int quantity);

            Console.Write("Введите процент скидки: ");
            string inputDiscount = Console.ReadLine();
            double.TryParse(inputDiscount, out double discountPercent);

            double totalBeforeDiscount = price * quantity;
            double discountAmount = totalBeforeDiscount * (discountPercent / 100);

            double totalAfterDiscount = totalBeforeDiscount - discountAmount;

            Console.WriteLine($"Общая сумма заказа с учётом скидки: {totalAfterDiscount:F2}");

            //Task_4 - По заданной длине окружности найти площадь круга по формуле S = pi*R*R,
            //радиус вычислить из формулы длины окружности: L=2*pi*R. Примечание: pi = 3.14.

            const double pi = 3.14;

            Console.Write("Введите длину окружности: ");
            string input_2 = Console.ReadLine();
            double.TryParse(input_2, out double circumference);

            double radius_1 = circumference / (2 * pi);

            double area = pi * radius_1 * radius_1;

            Console.WriteLine($"Площадь круга: {area:F2}");

            //Task_5 - Пользователь вводит 4-значное число. Поменять в нём местами первую и последнюю цифры и вывести результат на экран.
            Console.Write("Введите четырехзначное число: ");
            string input_3 = Console.ReadLine();

            int.TryParse(input, out int number);

            int thousands = number / 1000;
            int hundreds = (number / 100) % 10;
            int tens = (number / 10) % 10;
            int units = number % 10;
            int newNumber = units * 1000 + hundreds * 100 + tens * 10 + thousands;
            Console.WriteLine($"Новое число: {newNumber}");

            //Task_6 - Написать программу, которая преобразует введенное пользователем количество дней в количество полных недель и оставшихся дней.
            //Например, пользователь ввел 17 дней, программа должна вывести на экран 2 недели и 3 дня.

            Console.Write("Введите количество дней: ");
            string input_4 = Console.ReadLine();
            int.TryParse(input_4, out int totalDays);

            int weeks = totalDays / 7;
            int remainingDays = totalDays % 7;

            Console.WriteLine($"{totalDays} дней это {weeks} недели(ь) и {remainingDays} дней(я).");

            //Task_7 - N школьников делят K яблок поровну, неделящейся остаток остается в корзине.
            //Сколько яблок достанется каждому школьнику? Сколько яблок останется в корзинке?

            Console.Write("Введите количество школьников: ");
            string inputStudents = Console.ReadLine();
            int.TryParse(inputStudents, out int students);

            Console.Write("Введите количество яблок: ");
            string inputApples = Console.ReadLine();
            int.TryParse(inputApples, out int apples);

            int applesPerStudent = apples / students;
            int applesLeft = apples % students;
            Console.WriteLine($"Каждому школьнику достанется {applesPerStudent} яблок(а).");
            Console.WriteLine($"В корзине останется {applesLeft} яблок(а).");
        }
    }
}
