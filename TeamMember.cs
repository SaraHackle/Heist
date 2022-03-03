using System;


namespace Heist 
{
    public class TeamMember
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public double Courage {get; set;}

        public TeamMember(string name, int skillLevel, double courageLevel)
        {
            Name = name;
            SkillLevel = skillLevel;
            Courage = courageLevel;
        }

    }

}