using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
namespace Mouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var CoordinateOfFirstPlace = Cursor.Position;
            var firstcoordinate = new MouseCoordinate(CoordinateOfFirstPlace.X, MouseCoordinateStatus.Stand);
            Console.WriteLine("stand");
            var mousecoordinates = new List<MouseCoordinate>();
            while (true)
            {
                Thread.Sleep(1000);
                var newcursorcoordinate = Cursor.Position;
                var currentposition = newcursorcoordinate.X > firstcoordinate.Horizontal ? 
                    new MouseCoordinate(newcursorcoordinate.X, MouseCoordinateStatus.MoveToRight) :
                    newcursorcoordinate.X < firstcoordinate.Horizontal ? 
                    new MouseCoordinate(newcursorcoordinate.X, MouseCoordinateStatus.MoveToLeft) :
                    new MouseCoordinate(newcursorcoordinate.X, MouseCoordinateStatus.Stand);
                mousecoordinates.Add(currentposition);
                Console.WriteLine(currentposition.Status);
                firstcoordinate = mousecoordinates.Last();
            }
        }
    }
}
