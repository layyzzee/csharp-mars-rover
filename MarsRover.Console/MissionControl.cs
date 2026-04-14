using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Terminal
{
    public class MissionControl
    {
        private List<Rover> allRovers = new List<Rover>();  //Logic is here, need to add a method of adding any created rovers to the list (maybe just create a scenario with random rovers)


        public bool IsPositionEmpty(Position position)
        {
            foreach (Rover rover in allRovers)
            {
                var tempRovers = allRovers;
                tempRovers.Remove(rover);
                for (int i = 0; i < tempRovers.Count; i++)
                {
                    if (rover.CurrentPosition == tempRovers[i].CurrentPosition)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
