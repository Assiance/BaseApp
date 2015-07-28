using System;
using BaseApp.Domain.Models.User;

namespace BaseApp.Domain.Models
{
    public class LogAction
    {
        public int Id { get; set; }
        public DateTime PerformedAt { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public ApplicationUser PerformedBy { get; set; }
        public string Description { get; set; }

        public LogAction(ApplicationUser performedBy, string action, string controller, string description)
        {
            PerformedBy = performedBy;
            Action = action;
            Controller = controller;
            Description = description;
            PerformedAt = DateTime.Now;
        } 
    }
}