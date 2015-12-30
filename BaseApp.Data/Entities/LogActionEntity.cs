using System;
using BaseApp.Data.Entities.User;

namespace BaseApp.Data.Entities
{
    public class LogActionEntity
    {
        public int Id { get; set; }
        public DateTime PerformedAt { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public ApplicationUserEntity PerformedBy { get; set; }
        public string Description { get; set; }

        public LogActionEntity(ApplicationUserEntity performedBy, string action, string controller, string description)
        {
            PerformedBy = performedBy;
            Action = action;
            Controller = controller;
            Description = description;
            PerformedAt = DateTime.Now;
        } 
    }
}