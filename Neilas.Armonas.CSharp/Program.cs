using System;

namespace Neilas.Armonas.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // floor nummber that ege will break
            int floorBreak = 14;
            //floor starts from 0
            int floor = 0;
            // number of egges
            int numbEggs = 2;

            while (floor <= floorBreak)
            {
                Console.WriteLine("Egg was droped from " + floor + " floor");
                //incriment by 2 because you have 2 eggs and if one break you can trow egg from floor bellow it
                floor += 2;

                if (numbEggs <= 1)
                {
                    floor -= 1;
                    break;
                }
                else
                {
                    if (floorBreak <= floor)
                    {
                        Console.WriteLine("Egg was droped from " + floor + " floor and it broke");
                        floor -= 1;
                        numbEggs -= 1;
                        //for odd nummber
                        if (floorBreak <= floor)
                        {
                            Console.WriteLine("Second egg was droped from " + floor + " floor and it broke");
                            numbEggs -= 1;
                            break;
                        }
                        
                    }
                }
            }
            // do while floor is less or equal to floor that egg breaks is 
            
            floor -= 1;
            Console.WriteLine("Highes floor egg can be droped without breaking is " + floor +" floor");
            
        }
    }
}
