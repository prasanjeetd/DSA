using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interviews
{
    public class TopFloorOfBuilding
    {
        public int MaxFloor(int floor, int elevators, int[] startFloor, int[] endFloor)
        {
            int[,] floors = new int[elevators + 1, floor + 1];


            for (int i = 0; i < startFloor.Length; i++)
            {
                int s = startFloor[i];
                int e = endFloor[i];

                for (int j = s; j <= e; j++)
                {
                    floors[i + 1, j] = 1;
                }
            }

            int flr = 1;
            int elv = 1;

            do
            {
                for (; floors[elv, flr] == 1 && flr < floor; flr++)
                {

                }

                flr--;

                int elvCnt = 0;

                int elvatorNo = elevators % elv + 1;
                while (floors[elvatorNo, flr] != 1 && elvCnt < elevators)
                {
                    elv++;
                    elvCnt++;
                    elvatorNo = elevators % elv;
                }


                if (floors[elv, flr] != 1) return flr;

            } while (flr < floor);

            return flr;
        }
    }
}
