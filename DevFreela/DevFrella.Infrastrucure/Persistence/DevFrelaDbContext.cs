using DevFreela.Core.Entities;

namespace DevFrella.Infrastrucure.Persistence
{
    public class DevFrelaDbContext
    {
        public DevFrelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha descrição do Projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha descrição do Projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha descrição do Projeto 3", 1, 1, 30000),
            };

            Users = new List<User>
            {
                new User("Fabio Maciera", "fabiomacieira16@gmail.com", new DateTime(1992, 1, 1)),
                new User("Kurt Cobain", "kutcobain@gmail.com", new DateTime(1994, 1, 1)),
                new User("Maria Crazy", "marycrazy@gmail.com", new DateTime(1998, 1, 1)),
            };

            Skills = new List<Skill>
            {
                new Skill(".Net Core"),
                new Skill("C#"),
                new Skill("SQL"),
            };
        }

        public List<Project> Projects { get; private set; }
        public List<User> Users { get; private set; }
        public List<Skill> Skills { get; private set; }
    }
}
