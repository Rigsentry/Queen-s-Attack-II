using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queen_s_Attack_II
{
    public class Coordinates
    {
        public int Row { get; }
        public int Column { get; }
        
        public Coordinates(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
    class Program
    {
        private static bool CheckIfObstacle(Coordinates coordinates, List<Coordinates> obstacles)
        {
            foreach(var obstacle in obstacles)
            {
                if(obstacle.Row == coordinates.Row && obstacle.Column == coordinates.Column)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsNextCoordinateInsideBoard(Coordinates currentCoordinate, Coordinates direction, int boardSize)
        {
            if(currentCoordinate.Row + direction.Row > 0 
                && currentCoordinate.Row + direction.Row <= boardSize 
                && currentCoordinate.Column + direction.Column > 0 
                && currentCoordinate.Column + direction.Column <= boardSize)
            {
                return true;
            }
            return false;
        }

        private static List<Coordinates> GetAttackDirections()
        {
            List<Coordinates> attackDirections = new List<Coordinates>();
            attackDirections.Add(new Coordinates(0, -1));
            attackDirections.Add(new Coordinates(-1, -1));
            attackDirections.Add(new Coordinates(-1, 0));
            attackDirections.Add(new Coordinates(-1, 1));
            attackDirections.Add(new Coordinates(0, 1));
            attackDirections.Add(new Coordinates(1, 1));
            attackDirections.Add(new Coordinates(1, 0));
            attackDirections.Add(new Coordinates(1, -1));
            return attackDirections;
        }
       
        static void Main(string[] args)
        {
            ////SAMPLE INPUT 0
            //int n = 4;//number of rows/columns in board
            //int k = 0;//obstacles
            //Coordinates queenLocation = new Coordinates(4, 4);
            //List<Coordinates> obstacles = new List<Coordinates>();

            ////SAMPLE INPUT 1
            //int n = 5;//number of rows/columns in board
            //int k = 3;//obstacles
            //Coordinates queenLocation = new Coordinates(4, 3);
            //List<Coordinates> obstacles = new List<Coordinates>();
            //obstacles.Add(new Coordinates(5, 5));
            //obstacles.Add(new Coordinates(4, 2));
            //obstacles.Add(new Coordinates(2, 3));

            ////SAMPLE INPUT 2
            //int n = 1;//number of rows/columns in board
            //int k = 0;//obstacles
            //Coordinates queenLocation = new Coordinates(1, 1);
            //List<Coordinates> obstacles = new List<Coordinates>();

            //SAMPLE INPUT 3
            int n = 100000;//number of rows/columns in board
            int k = 0;//obstacles
            Coordinates queenLocation = new Coordinates(4187, 5068);
            List<Coordinates> obstacles = new List<Coordinates>();
            List<Coordinates> attackDirections = GetAttackDirections();
            int attackableSquares = 0; 
            foreach(var direction in attackDirections)
            {
                var currentCoordinate = queenLocation;

                while(IsNextCoordinateInsideBoard(currentCoordinate, direction, n))
                {
                    currentCoordinate = new Coordinates(currentCoordinate.Row + direction.Row, currentCoordinate.Column + direction.Column);
                    var isObstacle = CheckIfObstacle(currentCoordinate, obstacles);
                    if (!isObstacle)
                    {
                        attackableSquares++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(attackableSquares);
            Console.ReadKey();


        }
    }
}
