using System;
namespace Checklist.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool Completed { get; set; }
    }
}