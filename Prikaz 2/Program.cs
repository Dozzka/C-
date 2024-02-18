using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Prikaz
{
    public class Soldiers
    {
        public int Index;
        public string Rark;
        public string Command;
        public bool Prior = false;
        public List<string> ranksList = new List<string>
        {
            "Рядовой",
            "Ефрейтор",
            "Младший сержант",
            "Сержант",
            "Старший сержант",
            "Старшина",
            "Прапорщик",
            "Старший прапорщик",
            "Младший лейтенант",
            "Лейтенант",
            "Старший лейтенант",
            "Капитан",
            "Майор",
            "Подполковник",
            "Полковник",
            "Генерал-майор",
            "Генерал-лейтенант",
            "Генерал-полковник",
            "Генерал армии",
            "Маршал Российской Федерации"
        };
        public List<string> Commands = new List<string>
        {
            "Отдых",
            "Варить кашу",
            "Рассказывать анекдот",
            "Чистить картошку",
            "Мыть полы",
            "Красить траву",
            "Стоять молча",
            "Бег от дедов",
            "Отжимания от пола",
            "Спасать планету"
        };

        public Soldiers(string Command)
        {
            Random random = new Random();
            this.Index = random.Next(9999999);
            this.Command = Command;
            if (Command.Contains("*")) { Prior = true; }
            this.Rark = ranksList[random.Next(ranksList.Count)];
        }
        public Soldiers()
        {
            Random random = new Random();
            this.Index = random.Next(9999999);
            this.Prior = (random.Next(0, 5) == 3 ? true : false);
            this.Command = Commands[random.Next(Commands.Count)];
            this.Rark = ranksList[random.Next(ranksList.Count)];
        }
        public int GetIerarhikRank(string Rank)
        {
            return ranksList.IndexOf(Rank);

        }
    }
    public class PunktSvazi
    {

        public Soldiers[] Soldier;
        int CountSoldiers = 0;
        public PunktSvazi(Soldiers[] Soldiers)
        {
            this.Soldier = Soldiers;
            CountSoldiers = Soldiers.Length;
        }

        public List<string> Ps()
        {
            List<string> result = new List<string>();
            Dictionary<string, int> Stat = new Dictionary<string, int>();
            string[] OldCommands = new string[CountSoldiers];


            List<string> CurrentCommand = new List<string>();
            int FromWhom = -1;
            for (int i = 0; i < CountSoldiers; i++)
            {
                if (Stat.ContainsKey(Soldier[i].Rark)) { Stat[Soldier[i].Rark]++; }
                else { Stat.Add(Soldier[i].Rark, 1); }

                if (CurrentCommand.Count == 0 || Soldier[i].Prior) // Если приказа нет или приоритет
                {
                    OldCommands[i] = Soldier[i].Command + " |ОСТАВИЛ|";
                    CurrentCommand.Add(Soldier[i].Command);
                    FromWhom = Soldier[i].GetIerarhikRank(Soldier[i].Rark);
                    Soldier[i].Command = null;


                }
                else if (Soldier[i].GetIerarhikRank(Soldier[i].Rark) < FromWhom) // Если ниже по званию
                {
                    OldCommands[i] = Soldier[i].Command + " -> ";
                    Soldier[i].Command = CurrentCommand.Last();
                    CurrentCommand.RemoveAt(CurrentCommand.Count - 1);
                    FromWhom = -1;
                }

                else
                {
                    OldCommands[i] = (Soldier[i].Command + " |ОСТАВИЛ|"); // Оставляем приказ
                    CurrentCommand.Add(Soldier[i].Command);
                    Soldier[i].Command = null;
                    FromWhom = Soldier[i].GetIerarhikRank(Soldier[i].Rark);

                }

            }


            for (int i = 0; i < Soldier.Length; i++)
            {

                result.Add(Soldier[i].Index + " " + Soldier[i].Rark + " " + OldCommands[i] + (Soldier[i].Prior ? "*" : null) + Soldier[i].Command);


            }
            result.Add("Отсалось в ПС: " + String.Join(", ", CurrentCommand.ToArray()));

            foreach (string statistika in Stat.Keys) { result.Add(statistika + " " + Stat[statistika]); }

            return result;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Кол-во солдат: ");
            int CountSoldiers;
            while (true)
            {
                try
                {
                    CountSoldiers = Convert.ToInt32(Console.ReadLine());
                    if (CountSoldiers <= 0) { throw new InvalidOperationException("Меньше 1"); ; }
                    break;
                }
                catch { Console.WriteLine("Напишите число начиная с 1"); }
            }
            Soldiers[] Soldier = new Soldiers[CountSoldiers];

            for (int i = 0; i < CountSoldiers; i++)
            {
                Console.WriteLine("Приказ для солдата №" + (i + 1));
                string Command = Console.ReadLine();
                if (Command == "") { Soldier[i] = new Soldiers(); }
                else { Soldier[i] = new Soldiers(Command); }
            }

            /*            for (int i = 0; i < Soldier.Length; i++)
                        {
                            Console.WriteLine(Soldier[i].Index + " " + Soldier[i].Rark + " " + Soldier[i].Command);
                        };*/
            PunktSvazi Sold = new PunktSvazi(Soldier);

            foreach (string stroka in Sold.Ps())
            {
                Console.WriteLine(stroka);

            }

        }
    }
}

