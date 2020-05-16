using System.Collections.Generic;

namespace PersonalWebsite.Models.Home
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            Buttons = new List<ButtonViewModel>();
        }

        public IList<ButtonViewModel> Buttons { get; set; }
    }
}
