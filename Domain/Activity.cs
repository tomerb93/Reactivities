namespace Domain
{
    public class Activity // class relates to the table in the database, 
                          // and the properties relate to the columns in the table
    {
        public Guid Id { get; set; } // calling it Id will make EF Core automatically 
                                     // recognize it as the primary key
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}