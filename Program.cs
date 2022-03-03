using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");
            Console.Write("What's your team member's name? ");
            string inputTeamMemberName = Console.ReadLine();

            Console.Write("What's your team member's skill level? (1-50) ");
            var inputTeamMemberSkill = int.Parse(Console.ReadLine());

            Console.Write("What's your team member's courage level? (0.0 - 2.0) ");
            var inputTeamMemberCourage = double.Parse(Console.ReadLine());

            Console.WriteLine($"Team Member Stats: \n Name: {inputTeamMemberName} \n Skill Level: {inputTeamMemberSkill} \n Courage Level: {inputTeamMemberCourage}");
        
        }
    }
}
