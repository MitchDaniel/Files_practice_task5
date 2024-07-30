namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parth = @"C:\Users\Brill\Desktop\Новый текстовый документ (2).txt";
            //Console.WriteLine(IsContains(parth, "Привет"));
            //Console.WriteLine(IsContains(parth, "нового", out int position));
            //Console.WriteLine($"Number of string: {position}");
            //Console.WriteLine(CountOfWords(parth, "Поиск"));
            Console.WriteLine(CountReverceOfWords(parth, "ксиоП"));

        }
        static bool IsContains(string parth, string word)
        {
            if(parth == null || word == null)
            {
                throw new ArgumentNullException();
            }
            if(!File.Exists(parth))
            {
                throw new FileNotFoundException();
            }
            string[] words = File.ReadAllLines(parth);
            foreach (var item in words)
            {
                if(item.Contains(word))
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsContains(string parth, string word, out int position)
        {
            position = -1;
            if (parth == null || word == null)
            {
                throw new ArgumentNullException();
            }
            if (!File.Exists(parth))
            {
                throw new FileNotFoundException();
            }
            string[] words = File.ReadAllLines(parth);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(word))
                {
                    position = i + 1;
                    return true;
                }
            }
            return false;
        }

        static int CountOfWords(string parth, string word)
        {
            int count = 0;
            if (parth == null || word == null)
            {
                throw new ArgumentNullException();
            }
            if (!File.Exists(parth))
            {
                throw new FileNotFoundException();
            }
            string[] words = File.ReadAllLines(parth);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(word))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountReverceOfWords(string parth, string word)
        {
            int count = 0;
            word = new string(word.Reverse().ToArray());
            if (parth == null || word == null)
            {
                throw new ArgumentNullException();
            }
            if (!File.Exists(parth))
            {
                throw new FileNotFoundException();
            }
            string[] words = File.ReadAllLines(parth);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(word))
                {
                    count++;
                }
            }
            return count;
        }
    }
}


//Приложение предоставляет пользователю возможность поиска по файлу:
//* Поиск заданного слова. Приложение показывает найдено ли слово. 
//  Кроме этого, отображается информация о том, где найдено совпадение.
//* Поиск количества вхождения слова в файл. Приложение отображает количество раз, сколько найдено слово.
//* Поиск заданного слова в обратном порядке. Например, пользователь ищет слово moon. 
//  Это значит, что приложение ищет слово moon в обратном порядке: noom.
//  По результатам поиска, приложение отображает количество вхождений