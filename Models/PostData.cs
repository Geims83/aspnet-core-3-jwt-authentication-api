using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class PostData
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}