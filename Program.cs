using FootballLeague.Context;
using FootballLeague.Entities;

namespace FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext context = new AppDbContext())
            {
                Coach c1 = new Coach()
                {
                    Name = "Pep Guardoila",
                    Nationality = "Spain",
                    Type = 'M',
                   
                }; 
                context.Add(c1);

            } 
            
        }
    }
}
