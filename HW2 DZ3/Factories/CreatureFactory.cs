using HW2_DZ3.Creatures;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            bool flag = false;

            do
            {
                if (flag) { Console.WriteLine("\nВы ввели не подходящие данные. Попробуйте снова"); }

                result = Console.ReadLine();
                flag = true;
            }
            while (!nameAndSurnamePattern.IsMatch(result));

            return result;
        }

        //принимает ввод из консоли: 1 - мужчской пол, 2 _ женский, 3  НЕИЗМЕВСТНЫЙ пол
        public Gender genderInput()
        {
            Gender result;

            bool flag = false;

            do
            {

                if (!Enum.TryParse(Console.ReadLine(), out result) || !Enum.IsDefined(typeof(Gender), result))
                {
                    Console.WriteLine("Неверный ввод! Пожалуйста, введите 1, 2 или 3.");
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Выбранный пол: " + result);
                    flag = false;
                }

                
            }
            while (flag);


            return result;
        }


    }
}
