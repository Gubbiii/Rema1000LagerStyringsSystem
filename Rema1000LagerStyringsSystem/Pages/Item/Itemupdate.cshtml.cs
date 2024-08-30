using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rema1000LagerStyringsSystem
{
    public class ItemUpdateModel : PageModel
    {
        [BindProperty]
        public Item item { get; set; }
        private IItem repo;

        public ItemUpdateModel(IItem repository)
        {
            repo = repository;
        }
        public IActionResult OnGet(int Id)
        {
            item = repo.GetItem(Id);
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            repo.UpdateItem(item);
            return RedirectToPage("ItemPrint");
        }
    }
}
