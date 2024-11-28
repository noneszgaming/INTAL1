using System.Text.Json.Serialization;
using Microsoft.AspNetCore.HttpLogging;
using Newtonsoft.Json;
using PlanningProject.Models;

namespace PlanningProject.Models

{ 
    public class IssueResponse
    {
        public string Expand { get; set; }
        public int StartAt {  get; set; }

        public int MaxResults { get; set; }
        public int Total { get; set; }
        public List<Issue> Issues { get; set; }
    }

    public class Issue
    {
        public string Key { get; set; }
        public Fields Fields { get; set; }
    }

    public class Fields
    {
        public double? customfield_10016 { get; set; }
        public string Description { get; set; }
        public Sprint Sprint { get; set; }

    }
}
