using System.ComponentModel.DataAnnotations;
using Contact_Book.Data;

namespace Contact_Book.Models
{
    using static DataConstants;
    public class ContactSearchFormModel
    {
        [StringLength(MaxKeywordLength)]
        public string Keyword { get; init; }

        public IEnumerable<ContactViewModel> Contacts { get; set; } = new List<ContactViewModel>();
    }
}
