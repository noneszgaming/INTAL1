namespace PlanningProject.Pages.Shared.Components
{
    public class SprintListElementViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int CurrentParticipants { get; set; }
        public int TotalParticipants { get; set; }
    }
}
