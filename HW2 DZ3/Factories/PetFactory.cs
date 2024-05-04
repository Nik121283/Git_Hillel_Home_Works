using HW2_DZ3.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW2_DZ3.Facrories
{
    public class PetFactory : CreatureFactory
    {
        // контоль ввода возраста животного, пропускает от 1 до 40 лет
        public override int ControledAgeInput()
        {
            int result = 0;
            bool flag = false;
            do
            {
                if (flag) { Console.WriteLine("\nВы ввели не подходящие данные. Попробуйте снова"); }

                result = int.Parse(Console.ReadLine());
                flag = true;
            }
            while (! (result > 0 & result < 40));

            return result;
        }

        public override Creature createCreature()
        {
            
            Console.WriteLine("\nСоздаем новое домашнее животное\n");

            Console.WriteLine("Введите имя домашнего животного");
            string FirstName = ControledDataInput();

            Console.WriteLine("Введите вид и породу домашнего животного");
            string Vid_i_poroda = ControledDataInput();

            Console.WriteLine("Введите возраст животного");
            int age = ControledAgeInput();

            Console.WriteLine("Выберите гендер: 1 - мужчина, 2 - женщина, НЕИЗВЕСТНО - 3");
            Gender gender = genderInput();

            Console.WriteLine("\n Новое животное создано");
            return new Pet(FirstName, Vid_i_poroda, age, gender);
        }
    }
}
