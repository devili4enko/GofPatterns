using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Run()
        {
            int operationNumber = 0;

            try
            {
                var proxy = new RobotBombDefuserProxy(42);
                proxy.WalkStraightForward(100);
                operationNumber++;
                proxy.TurnLeft();
                operationNumber++;
                proxy.TurnRight();
                operationNumber++;
                proxy.DefuseBomb();
            }
            catch (BadConnectionException)
            {
                Console.WriteLine("Here our exception");
                PlanB(operationNumber);
            }
        }

        static void PlanB(int currentAttemp)
        {
            var humanControlBomdDefuser = new RobotBombDefuser();
            if (currentAttemp==0)
            {
                humanControlBomdDefuser.WalkStraightForward(100);
                currentAttemp++;
            }
            if (currentAttemp == 1)
            {
                humanControlBomdDefuser.TurnLeft();
                currentAttemp++;
            }
            if (currentAttemp == 2)
            {
                humanControlBomdDefuser.TurnRight();
                currentAttemp++;
            }
            if (currentAttemp == 3)
            {
                humanControlBomdDefuser.DefuseBomb();
            }
        }

        static void Main(string[] args)
        {
            Run();
        }
    }
}
