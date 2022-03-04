using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize the heist crew
            HeistCrew heistCrew = new HeistCrew("Coolest Heist Crew Ever!");

            Console.WriteLine("Plan your Heist!");
            //code block runs while run boolean is true, becomes false when user doesn't enter a name
            bool run = true;
            while (run)
            {

                Console.Write("What's your team member's name? ");
                string inputTeamMemberName = Console.ReadLine();

                //condition to end while loop
                if (inputTeamMemberName == "")
                {
                    run = false;
                }
                else
                {
                    Console.Write("What's your team member's skill level? (1-50) ");
                    var inputTeamMemberSkill = int.Parse(Console.ReadLine());

                    Console.Write("What's your team member's courage level? (0.0 - 2.0) ");
                    var inputTeamMemberCourage = double.Parse(Console.ReadLine());

                    //create new team member
                    TeamMember newTeamMember = new TeamMember(inputTeamMemberName, inputTeamMemberSkill, inputTeamMemberCourage);

                    //add newest team member to the heist team list
                    heistCrew.addTeamMember(newTeamMember);




                }
            }

            //display all team member stats after user stops entering new names
            heistCrew.displayHeistCrew();

            //display a total count of heist team members
            Console.WriteLine($"Total number of team members: {heistCrew.HeistTeam.Count}");

            //create a new bank instance    
            Bank newBank = new Bank("Chase", 100);

            //create a total skill level
            int teamSkillLevel = heistCrew.TotalSkill();
            //display if team can successfully compelte the heist
            if (teamSkillLevel >= newBank.Difficulty )
            {
                Console.WriteLine("Success! Your team completed the heist");
            }
            else
            {
                 Console.WriteLine("FAIL! Straight to Jail, and you're still poor.");
                
            }
        }
    }
}
