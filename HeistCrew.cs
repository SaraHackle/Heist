using System;
using System.Collections.Generic;
using System.Linq;

namespace Heist
{
    public class HeistCrew
    {
        public string Name { get; }
        public List<TeamMember> HeistTeam = new List<TeamMember>();

        public HeistCrew(string name)
        {
            Name = name;
        }
        //method to add a team member to the HeistTeam
        public void addTeamMember(TeamMember teamMember)
        {
            HeistTeam.Add(teamMember);
        }

        //method that shows the HeistTeam by individual member
        public void displayHeistCrew()
        {
            foreach (TeamMember person in HeistTeam)
            {
                Console.WriteLine($"Team Member Stats: \n Name: {person.Name} \n Skill Level: {person.SkillLevel} \n Courage Level: {person.Courage}");
            }
        }

        //  method that creates new list of skill levels and adds them together
        public int TotalSkill()
        {
            return HeistTeam.ConvertAll<int>(team => team.SkillLevel).Sum();
        }

    }
}