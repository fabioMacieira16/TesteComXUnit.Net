﻿namespace DevFreela.Core.Entities
{
    public class ProjecComment : BaseEnity
    {
        public ProjecComment(string content, int idProject, int idUser)
        {
            Content = content;
            IdProject = idProject;
            IdUser = idUser;
        }

        public string Content { get; private set; }
        public int IdProject { get; private set; }
        public int IdUser { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
