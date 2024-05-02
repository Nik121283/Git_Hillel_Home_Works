using HW2_DZ3.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW2_DZ3.Facrories
{
    public abstract class CreatureFactory
    {

        abstract public Creature createCreature();

        public Regex nameAndSurnamePattern = new Regex(@"^[\p{L}]+$");

        public Regex userAge = new Regex(@"^[1-9][0-9]?");

        public Regex petAge = new Regex(@"^[1-3][0-9]?");

        abstract public int ControledAgeInput();       
                    
        // используется для проверки ввода имен, фамилий, клички живтоных. Пропускает только Unicode
        public string ControledDataInput()
        {
            string result = string.Empty;

            do
            {
                result = Console.ReadLine();
            }
            while (!nameAndSurnamePattern.IsMatch(result));

            return result;
        }

        //принимает ввод из консоли: М - мужчской пол, Ж _ женский, лубой др ввод НЕИЗМЕВСТНЫЙ пол
        public Gender genderInput()
        {
            Gender result = Gender.Unknown;

            switch (Console.ReadLine())
            {
                case "М":
                    result = Gender.Male;
                    Console.WriteLine("Вы выбрали мужской пол.");
                    break;
                case "Ж":
                    result = Gender.Female;
                    Console.WriteLine("Вы выбрали женский пол.");
                    break;
                default:
                    result = Gender.Unknown;
                    Console.WriteLine("Вы выбрали неизвестный гендер.");
                    break;
            }

            return result;
        }


    }
}
