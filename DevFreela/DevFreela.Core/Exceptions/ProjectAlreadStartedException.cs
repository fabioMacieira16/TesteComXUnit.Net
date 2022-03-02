namespace DevFreela.Core.Exceptions
{
    public class ProjectAlreadStartedException: Exception
    {
        public ProjectAlreadStartedException() : base("Project is already in started status")
        {

        }
    }
}
