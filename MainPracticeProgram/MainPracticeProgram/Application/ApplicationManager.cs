using MainPracticeProgram.Models;
using MainPracticeProgram.ViewModels;

namespace MainPracticeProgram.Application
{
    public class ApplicationManager
    {
        public void StartApplication()
        {
            NarutoViewModel characterinfo = new NarutoViewModel();

            int extension = int.Parse(Helpers.GetUSerInput("enter a number a character id"));

            var character = characterinfo.GetCharacterInfo(extension).Result;
    
            Console.WriteLine(character.Id);
            Console.WriteLine(character.Name);
            foreach (var tool in character.Tools) 
            { 
                Console.WriteLine($"{tool}");
            }
            Console.ReadLine();
        }

        public void StopApplication()
        {

        }
    }
}
